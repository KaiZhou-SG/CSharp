using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseConstructor
{
    public class Square : Shape
    {
        public decimal side_length { get; set; }

        public Square(int shapeID, string color, decimal side_length)
            : base(shapeID, color)
        {
            this.side_length = side_length;
            this.area = side_length * side_length;
        }
    }
}
