using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdLambda00
{
    /// <summary>
    /// 2014-06-16 Zhou Kai writes this program to 
    /// learn and practice the concept of Lambda expression.
    /// (parameter1, parameter2, ...) => expression-or-statement-block
    /// </summary>
    public class Company
    {
        delegate int Transformer(int i);
        Transformer sqr = x => x * x;

        public void PrintSqr(int i)
        {
            Console.WriteLine(sqr(i));

            Action[] actions = new Action[3];
            for (int j = 0; j < 3; j++)
            {
                actions[j] = () => Console.Write(j);
            }

            foreach (Action a in actions) a();
        }
    }
}
