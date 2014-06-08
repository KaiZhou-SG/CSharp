using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdDelegate01
{
    public class Calculator
    {
        /// <summary>
        /// Define a delegate type: Calculate .
        /// </summary>
        /// <param name="num1">The first operand.</param>
        /// <param name="num2">The second operand.</param>
        /// <returns>The result value after the calcuation.</returns>
        public delegate int Calculate(int num1, int num2);
        /// <summary>
        /// Declare a variable of the Calculate type. 
        /// Notice: the interesting thing is, a delegate is a type, but what it 
        /// defined(Calculate) is still a type, this type(Calculate) then can
        /// be used to define a variable(cal), it's the variable(cal) been used
        /// to invoke a real function.
        /// </summary>
        public Calculate cal;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private int Subtract(int num1, int num2)
        {
            return (num1 - num2);
        }

        public Calculator()
        {
            // Initialize the cal variable.
            cal = new Calculate(Add);
            // There're also another ways to initialize 
            // a Calculate type variable by:
            // can = Add
            cal += Subtract;
        }
    }
}
