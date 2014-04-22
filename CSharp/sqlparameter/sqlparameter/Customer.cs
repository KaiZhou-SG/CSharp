using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlParameter
{
    public class Customer
    {
        public string startStop { get; set; }

        public Customer()
        {
            startStop = String.Empty; 
        }

        public Customer(string startStop)
        {
            this.startStop = startStop;
        }

        public string GetStartStop(int jobId, int jobTripSeqNo)
        {
            string startStop = String.Empty;
            try
            { startStop = CustomerDAL.GetStartStop(jobId, jobTripSeqNo); }
            catch (SqlException sqe) { throw sqe; }
            
            return startStop;
        }
    }
}
