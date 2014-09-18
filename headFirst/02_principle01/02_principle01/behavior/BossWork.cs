using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;

namespace _02_principle01.behavior
{
    public class BossWork : People, iWork
    {
        public string work()
        {
            return "I'm the boss, my name is: " +
                this.LastName + " " + this.FirstName +
                " I'm working.";
        }
    }
}
