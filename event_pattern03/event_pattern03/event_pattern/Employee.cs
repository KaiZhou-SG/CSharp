using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_pattern03.event_pattern
{
    public class Employee
    {
        private decimal currentSalary;
        private decimal minimalSalary;

        public event EventHandler<MyEventArgs> salaryTooLow;

        public decimal CurrentSalary
        {
            get { return currentSalary; }
            set
            {
                if (value < minimalSalary)
                {
                    salaryTooLow(this, new MyEventArgs(
                        value, "Sorry, I can't, the salary is too low." +
                        "I want: " + minimalSalary.ToString() +
                        ", but you only offer: " + value.ToString()));
                    currentSalary = value;
                }
                else { currentSalary = value; }
            }
        }

        public Employee(decimal miniSalary, decimal currentSalary)
        {
            this.minimalSalary = miniSalary;
            this.currentSalary = currentSalary;

            this.CurrentSalary = currentSalary;
        }
    }
}
