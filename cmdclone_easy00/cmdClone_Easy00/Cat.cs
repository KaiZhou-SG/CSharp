using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdClone_Easy00
{   
    ///<summary>
    /// The class Cat demonstrates a deep copy, the Cat class
    /// (1) has value type members and reference type members
    /// (2) inherits the ICloneable interface which has a single Clone() function
    /// (3) uses Memberwiseclone() to clone its own value types
    /// (4) then use toy's own Clone() method to clone itself (this is deep copy, it allocates memory)
    /// (5) The Clone() method of Toy then invoke its own Memberwiseclone() method to clone its value types
    /// (6) The result is: catB is totally another new copy of catA(deep copy), instead of a shadow of catB
    /// (7) catB's toy not only has the same member values with catA's, but it also has its own memory location(deep copy)
    ///</summary>
    public class Cat : ICloneable
    {
        #region "Private Member Variables"
        private int id;
        private string name;
        private decimal weight;
        private Toy toy;
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
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Toy Toy_
        {
            get { return toy; }
            set { toy = value; }
        }
        #endregion

        #region "Constructor"
        public Cat()
        {
            id = 0;
            name = String.Empty;
            weight = 0m;
            toy = null;
        }

        public Cat(int id, string name, decimal weight, Toy toy)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.toy = toy;
        }
        #endregion

        #region "Methods"
        public object Clone()
        {
            // object.MemberwiseClone() will clone all VALUE type variables
            Cat newCat = (Cat)this.MemberwiseClone();
            newCat.toy = (Toy)toy.Clone();
            return newCat;
        }
        
        #endregion

    }
}
