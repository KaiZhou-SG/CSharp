using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseConstructor
{
    public class Shape
    {
        public decimal area{ get; set;}
        public int shapeID { get; set; }
        public string color { get; set; }

        public Shape(int shapeID, string color)
        {
            this.shapeID = shapeID;
            this.color = color;
        }
    }
}
