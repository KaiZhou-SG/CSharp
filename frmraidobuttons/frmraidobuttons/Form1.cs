using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRaidoButtons
{
    /// <summary>
    /// 2014-02-02 Zhou Kai writes this program to 
    /// learn and use the RadioButton control
    /// 
    /// Note: You'll find if one radiobutton is checkChanged,
    /// two message boxes will show
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Name);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton2.Name);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton3.Name);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton4.Name);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton5.Name);
        }


    }
}
