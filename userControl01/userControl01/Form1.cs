using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userControl01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnNtxt1.SetBtnConfirmClickBehavior(btnNtxtConfirmClicked);
        }

        private void btnNtxtConfirmClicked(object sender, EventArgs e)
        {
            lblInput.Text = btnNtxt1.input;
        }



    }
}
