using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlParameter
{
    public partial class frmMain : Form
    {
        private Customer cus;
        public frmMain()
        {
            cus = new Customer();
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int jobId = 0, jobTripSeqNo = 0;
            const string  errMsg = "Please input valid integer number for job id and job trip seq no.";
            if (!(Int32.TryParse(tbxJobId.Text, out jobId) &&
                Int32.TryParse(tbxJobTripSeqNo.Text, out jobTripSeqNo)))
            {
                MessageBox.Show(errMsg);
                lblStartStop.Text = String.Empty;
                return;
            }
            else
            {
                lblStartStop.Text = cus.GetStartStop(jobId, jobTripSeqNo);
            }
               
        }
    }
}
