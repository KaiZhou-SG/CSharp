using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string display = String.Empty;
            StringBuilder sbDisplay = new StringBuilder();

            display = "I want a \" and a \\ and a '";
            sbDisplay.Append(display);

            Console.WriteLine(display);
            Console.WriteLine(sbDisplay);
            Console.Read();
        }
    }
}
