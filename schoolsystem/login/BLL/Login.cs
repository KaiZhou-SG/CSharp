using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Login.DAL;

namespace SchoolSystem.Login.BLL
{
    public class Login
    {
        #region "Private Member Variables"
        private int userId;
        private string userName;
        private string passWord;
        #endregion

        #region "Public Properties"
        public int UserID;
        #endregion

        #region "Constructors"

        #endregion

        #region "Methods"
        public bool IsUserAlreadyLoggedIn(int userId)
        {
            return LoginDAL.IsUserAlreadyLoggedIn(userId);
        }

        public bool IsUserAlreadyLoggedIn(string userName)
        {
            return LoginDAL.IsUserAlreadyLoggedIn(userName);
        }

        public bool ForceUserLogout(int userId)
        {
            return LoginDAL.ForceUserLogout(userId); 
        }

        public bool ForceUserLogout(string userName)
        {
            return LoginDAL.ForceUserLogout(userName); 
        }
        #endregion
    }
}
