using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.baseclass;

namespace _02_principle01.behavior
{
    public class ProgrammerWork : People, iWork
    {
        public string work()
        {
            return "I'm a programmer, I'm working";
        }
    }
}
