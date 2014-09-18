using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    /// <summary>
    /// 2014-09-17 Zhou Kai adds this abstract class:  
    /// Animal. This base class will hold the parts that
    ///  stay the same
    /// </summary>
    public abstract class Animal
    {
        protected string name;
        protected int id;

        public string Name 
        { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }

        public Animal()
        { name = String.Empty; id = 0; }

        public Animal(string name, int id)
        { this.name = name; this.id = id; }

    }
}
