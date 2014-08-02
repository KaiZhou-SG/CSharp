using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdStringFind00
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            List<string> names = new List<string>{ "Zhou Kai", "Liu Yaqiao", "Xiong Jie", "Wan Chenchen", "Zhao Yi"};

            Console.WriteLine(names.Find(x => x.Equals("Zhou Kai")));
            Console.WriteLine(names.Find(x => x.Equals("zhou kai"))); // returns null instead of String.Empty
            Console.ReadKey();
        }
    }
}
