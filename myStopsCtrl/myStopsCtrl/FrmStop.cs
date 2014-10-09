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
    internal partial class FrmStop : Form
    {
        private CustomerDTO stop;
        public CustomerDTO GetSelectedStop() { return stop;}

        public FrmStop(BindingSource bdsStops)
        {
            InitializeComponent();

            myStop.BdsAddress = bdsStops;

        }

        private void btnOK_Click(object sender,
            EventArgs e)
        {
            stop = myStop.Current;
            
            // this.Hide();
            this.Close();
            // this.Dispose();
        
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
