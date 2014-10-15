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
using FM.TransportMaintenanceDLL.BLL;

namespace myStopChainCtrl
{
    internal partial class FrmStop : Form
    {
        private Stop stop;
        public Stop GetSelectedStop() { return stop; }

        public FrmStop(List<Stop> lstAllStops)
        {
            InitializeComponent();

            myStop.LstAllStops = lstAllStops;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            stop = myStop.Current;

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            stop = null;

            this.Close();
            this.Dispose();
        }

    }
}
