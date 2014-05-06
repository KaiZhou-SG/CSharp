using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler03
{
    public class Plan
    {
        /*
         * Plan is used as the appointment object
         * in the scheduler control
         */

        public DateTime Start
        {
            get;
            set;
        }
        public DateTime End
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int ResourceId
        {
            get;
            set;
        }
    }
}
