using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cmdRefToUnInitialized;

namespace cmdRefToUnInitialized
{
    public class Another
    {
        #region "Private Member Variables"
        private Program pg;

        #endregion 

        #region "Public Properties"
        
        #endregion

        #region "Constructors"
        public Another()
        {
            pg = new Program();
            pg.msgNullRef = "I'm from another.";
        }

        #endregion
    }
}
