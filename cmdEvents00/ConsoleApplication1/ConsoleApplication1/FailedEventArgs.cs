using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FailedEventArgs : System.EventArgs
    {
        private string message;

        public FailedEventArgs(string message)
        {
            this.message = message;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
