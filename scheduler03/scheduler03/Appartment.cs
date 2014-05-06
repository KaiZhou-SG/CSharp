using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler03
{
    public class Apartment
    {
        /*
         * Apartment is used as the resource object
         * of the scheduler control
         * 
         */

        public int ID
        {
            get;
            set;
        }

        public string Caption
        {
            get;
            set;
        }
    }

}
