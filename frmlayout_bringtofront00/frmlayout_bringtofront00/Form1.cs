using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLayout_BringToFront00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "BringToFront and SendToBack, I need a further study of the layout Z order"
        private void btnSwitchTo1_Click(object sender, EventArgs e)
        {
            grp1.BringToFront();    
        }

        private void btnSwitchTo2_Click(object sender, EventArgs e)
        {
            grp1.SendToBack();
        }

        #endregion
    }
}
