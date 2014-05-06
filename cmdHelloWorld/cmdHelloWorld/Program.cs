using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace cmdHelloWorld
{
    class Program
    {
        /*
         * 2013-10-29 Zhou Kai writes program to:
         * (1) Get the full command used to lunch the application
         * (2) Get the current working directory(which may be different from the directory containing the application)
         * (3) Get the full path to the executable or DLL containing the code that is currently executing
         */
        static int Main(string[] args)
        {
            const string strHelloWorld = "Hello, world!";

            Console.WriteLine("{0}", strHelloWorld);
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    Console.WriteLine("{0}", arg);
                }
            }
            else { return -1; } 


            Console.WriteLine("The full command is: {0}.", Environment.CommandLine);
            Console.WriteLine("The current working directory is: {0}.", Environment.CurrentDirectory);
            Console.WriteLine("The directory code currently being executed is: {0}.", Assembly.GetExecutingAssembly().CodeBase);

            return 0;
        }
    }
}
