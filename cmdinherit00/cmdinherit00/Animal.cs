using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdInherit00
{
    public abstract class Animal
    {
        #region "Private Member Variables"
        protected int id;
        protected string name;
        protected decimal weight;
        #endregion

        #region "Public Properties"
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        #endregion

        #region "Constructors"
        public Animal()
        {
            name = String.Empty;
            id = 0;
            weight = 0m;
        }
        public Animal(int id, string name, decimal weight)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
        }
        #endregion

        #region "Methods"
        abstract public decimal Eat();
        abstract public string Sound();
        
        #endregion
    }
}
