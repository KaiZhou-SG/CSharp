using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdClone_Easy00
{
    public class Toy : ICloneable
    {
        #region "Private Member Variables"
        private int id;
        private string name;
        private decimal price;

        #endregion

        #region "Public Properties"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region "Constructors"
        public Toy()
        {
            id = 0;
            name = String.Empty;
            price = 0m;
        }
        public Toy(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        #endregion

        #region "Methods"
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
}
