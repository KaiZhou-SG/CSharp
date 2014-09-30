using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.FMSystem.BLL;

namespace myStopsCtrl
{
    public partial class FrmStop : Form
    {
        private CustomerDTO stop;

        public FrmStop(BindingSource bdsStops, 
            CustomerDTO outSelectedStop)
        {
            InitializeComponent();

            stop = outSelectedStop;
            myStop.BdsAddress = bdsStops;

        }

        public CustomerDTO GetStop()
        {
            return this.stop;
        }

        private void btnOK_Click(object sender,
            EventArgs e)
        {
            stop = myStop.Current;

            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, 
            EventArgs e)
        {
            stop = null;

            this.Close();
            this.Dispose();
        }

    }
}
