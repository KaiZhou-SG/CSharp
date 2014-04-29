using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmDataGridViewRowDragDrop
{
    /// <summary>
    /// The abstract class : Fruit
    /// </summary>
    public abstract class Fruit
    {
        #region "Fields"
        public string name;
        public string origin;
        public decimal weight;
        public bool isAvailable;
        #endregion

        #region "Properties"
        /// <summary>
        /// Property : Name
        /// </summary>
        public virtual string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Property : Orign
        /// </summary>
        public virtual string Origin
        {
            get { return this.origin; }
            set { this.origin = value; }
        }

        /// <summary>
        /// Property : Weight
        /// </summary>
        public virtual decimal Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Property : IsAvailable
        /// </summary>
        public virtual bool IsAvailable
        {
            get { return this.isAvailable; }
            set { this.isAvailable = value; }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// The default constructor
        /// </summary>
        public Fruit()
        {
 
        }

        /// <summary>
        /// The constructor to initialize all the fields
        /// </summary>
        /// <param name="name">The fruit name</param>
        /// <param name="orign">The fruit origin</param>
        /// <param name="weight">The fruit weight</param>
        /// <param name="isAvailable">If the fruit is available</param>
        public Fruit(string name, string orign, decimal weight, bool isAvailable)
        {
            this.name = name;
            this.origin = orign;
            this.weight = weight;
            this.isAvailable = isAvailable;
        }
        #endregion

    }
}
