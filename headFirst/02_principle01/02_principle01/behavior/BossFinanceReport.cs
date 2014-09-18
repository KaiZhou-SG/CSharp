using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;

namespace _02_principle01.behavior
{
    public class BossFinanceReport : People, iFinanceReport
    {
        public string financeReport()
        {
            return "I'm the boss, I'm doing the finance report";
        }
    }
}
