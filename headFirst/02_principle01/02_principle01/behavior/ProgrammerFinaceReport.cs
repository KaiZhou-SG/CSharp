using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;

namespace _02_principle01.behavior
{
    public class ProgrammerFinaceReport : People, iFinanceReport
    {
        public string financeReport()
        {
            return "I'm a programmer, I'm doing a finance report.";
        }
    }
}
