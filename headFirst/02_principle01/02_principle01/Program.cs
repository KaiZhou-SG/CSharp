using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;
using _02_principle01.behavior;
using _02_principle01.helpers;

namespace _02_principle01
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            People p = new People("Kai", "Zhou", 0, Title.Programmer,
                new ProgrammerWork(), new ProgrammerEarnMoney(), new ProgrammerFinaceReport());
            People p2 = new People("Yaqiao", "Liu", 1, Title.Boss,
                new BossWork(), new BossEarnMoney(), new BossFinanceReport());

            Console.WriteLine(p.performWork());
            Console.WriteLine(p.performEarnMoney());
            Console.WriteLine(p.performFinanceReport());

            Console.WriteLine(p2.performWork());
            Console.WriteLine(p2.performEarnMoney());
            Console.WriteLine(p2.performFinanceReport());

            Console.Read();
        }
    }
}
