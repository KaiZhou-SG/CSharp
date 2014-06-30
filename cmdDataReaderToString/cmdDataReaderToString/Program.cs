using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cmdDataReaderToString
{
    /// <summary>
    /// 2014-06-30 Zhou Kai writes this program.
    /// This program is to try to read a field with a NULL value from Database table.
    /// The conclusion is: use dbReader["ColumnName"].ToString() is the safest.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            string strDbCon = "Server=ZHOUKAI\\SQL2012;Database=Resources;Trusted_Connection=True;";
            string strSqlQuery = "SELECT * FROM Driver WHERE ID = 11";

            using (var dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    var dbCmd = new SqlCommand(strSqlQuery, dbCon);

                    SqlDataReader dbReader = dbCmd.ExecuteReader();
                    while (dbReader.Read())
                    {
                        // first try, failed. Null exception when converting
                        int nNullField = Convert.ToInt32(dbReader["DefaultVehicleID"]);
                        // second try, failed, Null excpetion when converting
                        string strNullField1 = (string)dbReader["DefaultVehicleID"];
                        // third try, succeeded, convert Null field to ""
                        string strNullField2 = dbReader["DefaultVehicleID"].ToString();
                    }
                }
                catch (SqlException se) { Console.WriteLine(se.Message); }
                catch (InvalidCastException ie) { Console.WriteLine(ie.Message); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}
