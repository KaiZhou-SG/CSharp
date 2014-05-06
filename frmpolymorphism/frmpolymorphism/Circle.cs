using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPolymorphism
{
    class Circle : Shape
    {
        #region "Private Member Variables"
        private decimal r;
        #endregion

        #region "Public Properties"
        public decimal R
        {
            get { return r; }
            set { r = value; }
        }

        public override decimal Area
        {
            get { return CalcArea(); }
            protected set { /* area = value; */}
        }

        public override decimal Perimeter
        {
            get { return CalcPerimeter(); }
            protected set { /* perimeter = value; */}
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string Color
        {
            get { return color; }
            set { color = value ;}
        }
        #endregion

        #region "Constructors"
        public Circle()
            : base()
        {
            r = 0m;
        }

        public Circle(decimal r)
            : base()
        {
            this.r = r; 
        }

        public Circle(decimal r, string color, string name)
            : base(color, name)
        {
            this.r = r;
        }
        #endregion

        #region "Implementation of the abstract methods"
        public override decimal CalcArea()
        {
            return r * r * (decimal)Math.PI;
        }

        public decimal CalcArea(decimal r)
        {
            return r * r * (decimal)Math.PI;
        }

        public override decimal CalcPerimeter()
        {
            return 2 * r * (decimal)Math.PI;
        }

        public decimal CalcPerimeter(decimal r)
        {
            return 2 * r * (decimal)Math.PI; 
        }

        public override void SayName()
        {
            Console.WriteLine("I'm a circle.");
        }

        #endregion
    }
}
