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

        public FrmStop(List<CustomerDTO> lstStops, 
            CustomerDTO outSelectedStop)
        {
            InitializeComponent();

            BindingSource bdsStops = new BindingSource();
            stop = outSelectedStop;
            bdsStops.DataSource = lstStops;
            myStop.BdsAddress = bdsStops;

        }

        private void btnOK_Clicked(object sender,
            EventArgs e)
        {
            stop = myStop.Current;

        }

        private void btnCancel_Clicked(object sender,
            EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        public CustomerDTO GetStop()
        {
            return this.stop;
        }

    }
}
