using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPolymorphism
{
    public class Square : Shape
    {
        #region "Private Member Variables"
        private decimal l;
        private decimal w;
        #endregion

        #region "Public Properties"
        public decimal L
        {
            get { return l; }
            set { l = value; }
        }

        public decimal W
        {
            get { return w; }
            set { w = value; }
        }

        public override decimal Area
        {
            get { return CalcArea(); }
            protected set {}
        }

        public override decimal Perimeter
        {
            get { return CalcPerimeter(); }
            protected set {}
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string Color
        {
            get { return color; }
            set { color = value; }
        }

        #endregion

        #region "Constructors"
        public Square()
            : base()
        {
            this.l = 0m;
            this.w = 0m;
        }

        public Square(decimal l, decimal w) :
            base ()
        {
            this.l = l;
            this.w = w;
        }

        public Square(decimal l, decimal w, string color, string name)
            : base(color, name)
            
        {
            this.l = l;
            this.w = w;
        }

        #endregion

        #region "Implementation of the abstract methods of basc class Sharp"
        public override decimal CalcArea()
        {
            return l * w;
        }

        public override decimal CalcPerimeter()
        {
            return (l + w) * 2;
        }

        public override void SayName()
        {
            Console.WriteLine("I'm square.");
        }

        #endregion
    }
}
