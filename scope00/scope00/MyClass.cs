using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope00
{
    /// <summary>
    /// 2014-06-02 Zhou Kai writes this program to 
    /// learn and practice the concepts of:
    /// (1) declaration space, a declaration space is that within it, you cannot define two variables with a same name
    /// (2) class declaration space, when define a class, a class declaration space is created
    /// (3) local declaration space, when define a method, a local declaration space is created
    /// (4) nested local declaration space, a block of code {} inside a method creates a nested local declaration space
    /// 
    /// >>>
    /// (1) we can hide a class declaration space variable with a local declaration space variable
    /// (2) we cannot hide a local declaration space variable with a nested local declaration space variable
    /// </summary>
    public class MyClass
    {
        // class declaration space
        public int myInteger;
        public string myInteger; // invalid, cannot define two variables with a same name within a declaration space

        public void MyMethod()
        {
            // local declaration space
            int myInteger; // valid, hides

            if (true)
            {
                // nested local declaration space
                int myInteger; // invalid, cannot hide
            }
        }
    }
}
