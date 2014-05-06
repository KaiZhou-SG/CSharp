using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseConstructor
{
    public class Circle : Shape
    {
        public decimal r { get; set; }

        public Circle(int shapeID, string color, decimal r)
            : base(shapeID, color)
        {
            this.r = r;
            this.area = 3.14M * r * r;
        }

    }
}
