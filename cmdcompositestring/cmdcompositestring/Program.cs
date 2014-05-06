using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdCompositeString
{
    class Program
    {
        static void Main(string[] args)
        {
            const string strName = "zhou kai";
            const int nAge = 27;
            // notice that the argument index can be in any order
            string strWelcome = string.Format("{1}, with age {0}, you're welcome!", nAge, strName);
            Console.WriteLine("{0}", strWelcome);
            Console.Read();

            return;
        }
    }
}
