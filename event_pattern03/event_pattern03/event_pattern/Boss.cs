using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_pattern03.event_pattern
{
    public class Boss
    {
        private Employee aEmployee;

        public Boss()
        {
            aEmployee = new Employee(2000, 3000);
            aEmployee.salaryTooLow += salaryTooLow;
        }

        public decimal raiseSalary(decimal incresment)
        {
            return (aEmployee.CurrentSalary = 
                aEmployee.CurrentSalary + incresment);
        }

        public decimal deductSalary(decimal decrement)
        {
            return (aEmployee.CurrentSalary =
                aEmployee.CurrentSalary - decrement);
        }

        private void salaryTooLow(object sender, MyEventArgs e)
        {
            Console.WriteLine("Hi, I got your message: " + e.Message);
            Console.WriteLine("Sorry, I didn't notice that, can we negotiate?");
        }
    }
}
