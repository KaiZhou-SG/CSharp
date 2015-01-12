using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdOverride
{
    public class Apple : IFruit
    {
        public string SelfCheck()
        {
            return "Good!";
        }

    }
}
