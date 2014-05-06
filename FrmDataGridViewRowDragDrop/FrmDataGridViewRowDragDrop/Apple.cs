using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmDataGridViewRowDragDrop
{
    public class Apple : Fruit
    {
        /// <summary>
        /// The default constructor, derives from Fruit
        /// </summary>
        public Apple(): base()
        {
 
        }

        /// <summary>
        /// The constructor which initialize all fields, derives from Fruit
        /// </summary>
        /// <param name="name">The fruit name</param>
        /// <param name="orign">The fruit origin</param>
        /// <param name="weight">The fruit weight</param>
        /// <param name="isAvailable">If the fruit is available</param>
        public Apple(string name, string origin, decimal weight, bool isAvailable) :
            base(name, origin, weight, isAvailable)
        {
 
        }
    }
}
