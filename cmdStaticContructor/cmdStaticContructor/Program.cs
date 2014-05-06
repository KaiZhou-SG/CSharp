using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdStaticContructor
{
    /// <summary>
    /// 2014-04-22 Zhou Kai writes this program to 
    /// study the concept of "constructor".
    /// A constructor is any method which returns 
    /// an instance of this class. A constructor is basicly to
    /// create and initialize an object of this class and return
    /// to its caller.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the command line program
        /// </summary>
        /// <param name="args">Command line parameters</param>
        static void Main(string[] args)
        {
            Program pgm = CreateProgram();

            pgm.TalkAboutMySelf();

            Console.ReadKey();
        }

        /// <summary>
        /// A static constructor cannot have parameters, and
        /// neither access modifiers.
        /// </summary>
        static Program()
        {
            
        }

        public static Program CreateProgram()
        {
            Program pgm = new Program();
            
            pgm.id = 1;
            pgm.name = "I'm a program";

            return pgm;
        }

        /// <summary>
        /// Create a list of program objects.
        /// </summary>
        /// <param name="nCount">The quantity of Program objects to create</param>
        /// <returns>The list of created program objects</returns>
        public List<Program> CreateNPrograms(int nCount)
        {
            List<Program> lstPrograms = new List<Program>();

            for (int i = 0; i < nCount; i++)
            {
                lstPrograms.Add(CreateProgram());
            }

            return lstPrograms;
        }

        private Program()
        {
 
        }

        
        /// <summary>
        /// Private fields
        /// </summary>
        private int id;
        private string name;

        /// <summary>
        /// Public properties
        /// </summary>
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void TalkAboutMySelf()
        {
            Console.WriteLine("Hi, my name is: \"{0}\" and my id is: {1}.", this.name, this.id);
        }
    }
}
