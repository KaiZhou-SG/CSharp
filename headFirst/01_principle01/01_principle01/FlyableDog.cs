using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    /// <summary>
    /// 2014-09-17 Zhou Kai adds this class, it 
    /// inherits from a concrete class: Dog, and inherits
    /// from another interface: iFlyable
    /// </summary>
    public class FlyableDog : Dog, iFlyable
    {
        public FlyableDog() : base() { }
        public FlyableDog(string name, int id) : 
            base(name, id){}

        public string bark()
        { return name + ": I'm a flyable dog!!"; }

        public string fly()
        { return name + ": Ever see a dog fly?!"; }
    }
}
