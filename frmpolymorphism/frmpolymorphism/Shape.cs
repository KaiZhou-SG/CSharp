using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPolymorphism
{
    // 2013-12-06 Zhou Kai creates this abstract class,
    // note that abstract class will have no implementations
    // either for properties or methods. But can have body
    // for constructors.

    // It's a good practice to use "abstract" before a function name
    // to force the child class to implement a function.
    public abstract class Shape
    {
        #region "Protected Member Variables" 
        // private members are invisible to child classes,
        // protected members are visible to child classes
        protected decimal area;
        protected decimal perimeter;
        protected string color;
        protected string name;
        #endregion

        #region "Public Properties"
        abstract public decimal Area { get; protected set; }
        abstract public decimal Perimeter { get; protected set; }
        abstract public string Color { get; set; }
        abstract public string Name { get; set; }

        #endregion

        #region "Constructors"
        public Shape()
        {
            area = 0m;
            perimeter = 0m;
            color = String.Empty;
            name = String.Empty;
        }

        public Shape(string color, string name)
        {
            this.color = color;
            this.name = name;
        }
        #endregion

        #region "Protected Virtual Methods"
        public abstract decimal CalcArea();
        public abstract decimal CalcPerimeter();
        public abstract void SayName();
        
        #endregion

    }
}
