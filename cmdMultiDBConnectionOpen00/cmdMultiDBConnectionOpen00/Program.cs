using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cmdMultiDBConnectionOpen00
{
    /// <summary>
    /// 2014-07-02 Zhou Kai writes this program to test
    /// if we can open multi database connection and 
    /// execute commands with those connections in a same function before
    /// closing the previouse database connection first.
    /// The answer is yes.
    /// But do note that we cannot open multi  database transaction
    /// at the same time, we must commit the previous transaction
    /// before start another transaction.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            string strDbCon = "Server=ZHOUKAI\\SQL2012;Database=Resources;Trusted_Connection=True;";
            using (var dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    string sqlQuery1 = "SELECT [Name] FROM Driver WHERE ID = 1";
                    string sqlQuery2 = "SELECT [Name] FROM Driver WHERE ID = 2";
                    string sqlQuery3 = "SELECT [Name] FROM Driver WHERE ID = 3";

                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    var dbCmd = new SqlCommand(sqlQuery1, dbCon);
                    SqlDataReader dbReader = dbCmd.ExecuteReader();
                    dbReader.Read();
                    // what will happen if I try to open another database connection:
                    var dbCon2 = new SqlConnection(strDbCon);
                    if (dbCon2.State == ConnectionState.Closed) { dbCon2.Open(); } // it's OK to open another db connection 
                    // try to run command via this second db connection
                    var dbCmd2 = new SqlCommand(sqlQuery2, dbCon2);
                    SqlDataReader dbReader2 = dbCmd2.ExecuteReader(); // it's OK to run a command to the second db connection
                    dbReader2.Read();
                    // invoke a function which opens another db connection
                    OpenDbAgain(); // it's still OK
                }
                catch (SqlException se) { Console.WriteLine(se.Message); }
                catch (ApplicationException ae) { Console.WriteLine(ae.Message); }

            }
        }

        /// <summary>
        /// This function will open another database connection
        /// </summary>
        private static void OpenDbAgain()
        {
            string strDbCon = "Server=ZHOUKAI\\SQL2012;Database=Resources;Trusted_Connection=True;";
            using (var dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    string sqlQuery1 = "SELECT [Name] FROM Driver WHERE ID = 1";
                    string sqlQuery2 = "SELECT [Name] FROM Driver WHERE ID = 2";
                    string sqlQuery3 = "SELECT [Name] FROM Driver WHERE ID = 3";

                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    var dbCmd = new SqlCommand(sqlQuery1, dbCon);
                    SqlDataReader dbReader = dbCmd.ExecuteReader();
                    dbReader.Read();
                    // what will happen if I try to open another database connection:
                    var dbCon2 = new SqlConnection(strDbCon);
                    if (dbCon2.State == ConnectionState.Closed) { dbCon2.Open(); } // it's OK to open another db connection 
                    // try to run command via this second db connection
                    var dbCmd2 = new SqlCommand(sqlQuery2, dbCon2);
                    SqlDataReader dbReader2 = dbCmd2.ExecuteReader(); // it's OK to run a command to the second db connection
                    dbReader2.Read();
                }
                catch (SqlException se) { Console.WriteLine(se.Message); }
                catch (ApplicationException ae) { Console.WriteLine(ae.Message); }
            }
        }
    }
}
