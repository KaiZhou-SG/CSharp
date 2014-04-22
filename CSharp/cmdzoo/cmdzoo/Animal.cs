using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdZoo
{
    public abstract class Animal
    {
        #region "Private Member"
        private string strType;
        #endregion

        #region "Public Properties"
        public string Type
        {
            get { return strType; }
            set { strType = value; }
        }
        #endregion 

        #region "Methods"
        public void Sound()
        {
            Console.WriteLine("I'm animal");
        }
        #endregion

        #region "Constructors"
        public Animal()
        {
            Console.WriteLine("I'm parent");
        }
        #endregion
    }
}
