using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmScheduler00.UI
{
    internal partial class SetDriverAvailability : Form
    {
        internal bool Confirm { get; set; }

        internal SetDriverAvailability(string availability)
        {
            InitializeComponent();
            this.lblAvailability.Text = availability;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Confirm = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Confirm = false;
            this.Close();
        }
    }
}
