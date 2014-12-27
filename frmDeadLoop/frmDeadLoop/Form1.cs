using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDeadLoop
{
    /// <summary>
    /// 2014-09-30 Zhou Kai writes this program to 
    /// demonstrate a typical dead loop:
    /// In the text_changed event handler, change
    /// the text.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += txt_changed;
        }

        private void txt_changed(object sender, EventArgs e)
        {
            textBox1.Text = "dead loop";
        }
    }
}
