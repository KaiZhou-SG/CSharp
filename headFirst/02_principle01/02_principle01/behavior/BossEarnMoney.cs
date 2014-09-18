using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;

namespace _02_principle01.behavior
{
    public class BossEarnMoney : People, iEarnMoney
    {
        public static int month = 1;
        public const decimal fixedSalary = 10000m;

        public decimal earnMoney()
        {
            return fixedSalary * month ++;
        }
    }
}
