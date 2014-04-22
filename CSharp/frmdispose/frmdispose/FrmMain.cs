using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmDispose
{
    // 2014-01-20 Zhou Kai writes this program to 
    // test the behaiver of the .Dispose() method.
    // .Dispose() method comes from Compenent class
    public partial class FrmMain : Form
    {
        private FrmChild frmChild;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(frmChild, null) ||
                frmChild.IsDisposed)
            {
                frmChild = new FrmChild();
            }
            
            frmChild.Show();
            frmChild.BringToFront();
            frmChild.FormClosed += new FormClosedEventHandler(frmChild_FormClosed);
        }

        private void btnCloseChildFrom_Click(object sender, EventArgs e)
        {
            // call this method when the frmChild is already finalized by
            // the CLR, see what happens
            try
            {
                // if frmChild is null, NullReferenceException will happen
                // otherwise the Dispose() function works no matter the 
                // form is finalized or not, no errors occur
                frmChild.Close();
                frmChild.Dispose();
            }
            catch (NullReferenceException ne)
            {
                // do nothing
            }
            
        }

        private void frmChild_FormClosed(object sender, FormClosedEventArgs fce)
        {
            frmChild.Close();
            frmChild.Dispose();
        }


    }
}
