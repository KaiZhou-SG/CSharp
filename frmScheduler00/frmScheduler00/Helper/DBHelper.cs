using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frmScheduler00.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class DBHelper
    {
        public static string dbConnectionString = "Server = 127.0.0.1//SQL2012; Database = Resources; Trusted_Connection = True";

        public static string getDbConnectionString()
        {
            if (String.IsNullOrEmpty(dbConnectionString))
            {
                return "Server = 127.0.0.1//SQL2012; Database = Resources; Trusted_Connection = True";
            }
            else
            {
                return dbConnectionString;
            }
        }
    }
}
