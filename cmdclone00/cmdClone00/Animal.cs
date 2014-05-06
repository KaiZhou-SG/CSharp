using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdClone00
{
    abstract class Animal
    {
        #region "Protected Member Variables"
        protected int id;
        protected string name;
        #endregion 

        #region "Public Properties"
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion 

        #region "Constructors"
        public Animal()
        {
            id = 0;
            name = String.Empty;
        }
        public Animal(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        #endregion 

        #region "Methods"
        abstract public void Sound();
        abstract public void Move();
        #endregion
    }
}
