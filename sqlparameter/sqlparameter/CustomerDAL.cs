using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlParameter
{
    public class CustomerDAL
    {
        static internal string GetStartStop(int jobId, int jobTripSeqNo)
        {
            /*
             * 2013-10-21 Zhou Kai: 
             * The way to use Sql Parameter is:
             * (1) Write the Sql String as usual, but leave all the parameters as @XXX
             * (2) Use that Sql String as well as the SqlConnection object to create a SqlCommand object
             * (3) Use SqlCommand.Parameters.Add(XXX, local_varaible) to complete the command
             * (4) Execute that command.
             */
            string startStop = String.Empty;
            string strDbCon = "Server=ZHOUKAI\\SQL2012;Database=Transport;Trusted_Connection=Yes;";
            string strQuery = "SELECT FROM_STOP FROM TRK_JOB_DETAIL_TRIP_Tbl WHERE JOB_ID = @JobID " +
                              "AND JOBTRIP_SEQ_NO = @JobTripSeqNo";
            SqlConnection cn = new SqlConnection(strDbCon);
            SqlCommand cmd = new SqlCommand(strQuery, cn);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open) { cn.Open(); }
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("JobID", jobId));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("JobTripSeqNo", jobTripSeqNo));
                return Convert.ToString(cmd.ExecuteScalar());
            }
            catch (SqlException sqe) { throw sqe; }
            finally { cn.Close(); }
        }
    }
}
