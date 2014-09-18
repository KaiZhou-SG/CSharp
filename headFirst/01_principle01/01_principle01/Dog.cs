using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    public class Dog : Animal, iBarkable
    {
        public Dog() : base() { }

        public Dog(string name, int id) : base(name, id) 
        { }

        public string bark()
        {
            return  name + ": Wang, wang~~~";
        }
    }
}
