using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdTest00
{
    public class Program
    {
        static internal void Main(string[] args)
        {
            List<string> a = new List<string>();
            List<int> b = new List<int>();

            bool sameType = a.GetType() == b.GetType() ? true : false;

            Console.WriteLine(sameType.ToString());
            Console.ReadKey();
        }
    }
}
