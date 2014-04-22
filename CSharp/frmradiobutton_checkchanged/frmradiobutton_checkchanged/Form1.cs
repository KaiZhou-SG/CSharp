using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRadioButton_CheckChanged
{
    /// <summary>
    /// 2014-02-07 Zhou Kai writes this program to test the behavior of 
    /// databinding to the Checked property of  RadioButton
    /// </summary>
    public partial class Form1 : Form
    {
        private bool rbtChecked; // for the first group of 3 RadioButtons
        private bool rbtCheckedGroup2; // for the second group of 2 RadioButtons
        public bool Checked
        {
            get { return rbtChecked; }
            set 
            {
                rbtChecked = value;
                MessageBox.Show(String.Format("RadioButton1's current status is: {0}.\n" +
                "RadioButton2's current status is: {1}\nRadioButton3's current status is: {2}\n",
                    value.ToString(), radioButton2.Checked.ToString(), radioButton3.Checked.ToString()));
            }
        }
        public bool CheckedGroup2
        {
            get { return rbtCheckedGroup2; }
            set
            {
                rbtCheckedGroup2 = value;
                MessageBox.Show(String.Format("RadioButton4's current status is: {0}.\n" +
                "RadioButton5's current status is: {1}\n",
                 radioButton4.Checked.ToString(), radioButton5.Checked.ToString()));
            }
        }

        public Form1()
        {
            InitializeComponent();
            radioButton1.DataBindings.Add("Checked", this, "Checked");
            radioButton4.DataBindings.Add("Checked", this, "CheckedGroup2");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region "This block is another test"
        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton4.Checked)
        //    {
        //        CheckedGroup2 = true;
        //    }
        //}

        //private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton5.Checked)
        //    {
        //        CheckedGroup2 = false;
        //    }
        //}
        #endregion

    }
}
