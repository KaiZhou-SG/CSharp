using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdClone00
{
    public class Bird : ICloneable
    {
        #region "Private Member Variables"
        private Food food;
        private string name;
        private int id;
        #endregion

        #region "Public Properties"

        #endregion

        #region "Constructors"
        public Bird()
        {
            food = null;
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
