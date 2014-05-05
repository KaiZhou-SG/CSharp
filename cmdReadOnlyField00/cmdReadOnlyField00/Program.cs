using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdReadOnlyField00
{
    /// <summary>
    /// 2014-04-22 Zhou Kai writes this program to learn and practice
    /// the concept of "readonly"
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the command line program
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            Program pgm = new Program();
            
            pgm.TalkAboutMySelf();
            Console.ReadKey();
        }

        /// <summary>
        /// The default constructor
        /// </summary>
        public Program()
        {
            // The readonly modifier prevents a field from being
            // modified after construction, a read-only field can be assigned
            // only in its declaration or within the enclosing type's constructor.
            id = 10;
        }

        /// <summary>
        /// A public method
        /// </summary>
        public void TalkAboutMySelf()
        {
            Console.WriteLine("My id is: {0}", this.id);
        }

        /// <summary>
        /// A readonly field. The readonly field is 
        /// assigned when declaration, and later be 
        /// modified at construction. But after that, the readonly
        /// field can no longer be modified, it can only be 
        /// modified no later than the construction of its
        /// enclosing type.
        /// </summary>
        private readonly int id = 1;

        /// <summary>
        /// A public property for that 
        /// readonly field
        /// </summary>
        public int ID
        {
            get { return id; }
            private set { }
        }
    }
}
