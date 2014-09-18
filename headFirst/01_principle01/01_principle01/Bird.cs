using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    public class Bird : Animal, iFlyable
    {
        public Bird() : base() { }

        public Bird(string name, int id) : base(name, id) 
        { }

        public string fly()
        {
            return  name + ": You see, I can fly!!";
        }
    }
}
