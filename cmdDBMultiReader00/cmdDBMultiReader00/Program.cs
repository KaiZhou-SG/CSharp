using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cmdDBMultiReader00
{
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
                    dbReader.Close(); // must close first before running dbCmd.ExecuteReader() again
                    dbCmd = new SqlCommand(sqlQuery2, dbCon);
                    dbReader = dbCmd.ExecuteReader();
                }
                catch (SqlException se) { Console.WriteLine(se.Message); }
                catch (ApplicationException ae) { Console.WriteLine(ae.Message); }
                
            }
        }
    }
}
