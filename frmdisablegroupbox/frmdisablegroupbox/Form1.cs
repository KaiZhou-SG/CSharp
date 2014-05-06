using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDisableGroupBox
{
    /// <summary>
    /// 2013-11-07 Zhou Kai writes this application to 
    /// demostrate that if you enable / disable a GroupBox,
    /// then all the controls on that GroupBox will be
    /// enable / disable
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Event Handlers"
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            return;
        }
        #endregion
    }
}
