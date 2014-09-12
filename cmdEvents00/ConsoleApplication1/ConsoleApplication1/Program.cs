using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            Student s = new Student();
            Teacher t = new Teacher();
            s.failedHandler += t.RemindFailure;
            s.Grade = 0;
        }
    }
}
