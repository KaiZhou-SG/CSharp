using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope00
{
    /// <summary>
    /// To test the scope:
    /// (1) declare a variable as class member 
    /// (2) declare a variable with the same name in a method
    /// (3) declare a variable with the same name in a if...else... clause in the method
    /// </summary>
    public class Program
    {
        public int myInteger;

        internal static void Main(string[] args) // it's advised to use internal access modifier from MSDN
        {
            
        }

        private void MyMethod()
        {
            Console.WriteLine(myInteger); // valid

            if (true)
            {
                // int myInteger;  // invalid, because another 'myInteger' already appears
                                         // if comment out the line: 26, line 30 will be valid again
                Console.WriteLine(myInteger); // valid
            }

            // int myInteger; // if un-comment line: 35, line: 26, line: 32 will be invalid
                                    // to keep those two lines, use this.myInteger instead
        }
    }
}
