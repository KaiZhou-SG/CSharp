using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frmScheduler00.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal static class DBHelper
    {
        internal static string dbConnectionString = "Server = ZHOUKAI\\SQL2012; Database = Resources; Trusted_Connection = True";

        internal static string getDbConnectionString()
        {
            if (String.IsNullOrEmpty(dbConnectionString))
            {
                return "Server = ZHOUKAI\\SQL2012; Database = Resources; Trusted_Connection = True";
            }
            else
            {
                return dbConnectionString;
            }
        }
    }
}
