using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_pattern03.event_pattern
{
    public class MyEventArgs : EventArgs
    {
        private decimal currentSalary;
        private string message;

        public decimal CurrentSalary
        {
            get {return currentSalary;}
        }

        public string Message
        {
            get { return message; }
        }

        public MyEventArgs(decimal salary, string message)
        {
            this.currentSalary = salary;
            this.message = message;
        }
    }
}
