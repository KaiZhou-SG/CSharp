using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    public class Cat : Animal, iBarkable
    {
        public Cat() : base() { }

        public Cat(string name, int id) : base(name, id) 
        { }

        public string bark()
        {
            return  name + ": Miaouuu~~~";
        }
    }
}
