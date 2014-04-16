using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmRef04
{
    /// <summary>
    /// 2014-04-16 Zhou Kai writes this program to test:
    /// the difference between String and StringBuilder on
    /// the reference assignment.
    /// 
    /// For two strings str1, str2; 
    /// use str1 = str2 makes their contents equal.
    /// And then modify str2, str1 will not be modified,
    /// modify str1, and str2 will also not be modified.
    /// 
    /// Now let's try using StringBuilder, see what happens.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            this.btnChangeSB2.Click += new EventHandler(btnChangeSB2_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sb1 = new StringBuilder("I'm string builder 1");
            sb2 = new StringBuilder("I'm string builder 2");
        }

        private void btnChangeSB2_Click(object sender, EventArgs e)
        {
            sb1 = sb2;
            // now I change the value of sb2, let's see what happens to sb1
            sb2.Append("\n Appended something to string builder 2.");
            // then change the value of sb1, let's see what happens to sb2
            sb1.Append("\n Appended something to string builder 1.");

            MessageBox.Show(String.Format("sb1: {0}\nsb2: {1}", sb1.ToString(), sb2.ToString()));
        }

        #region "Private member variables"
        private StringBuilder sb1;
        private StringBuilder sb2;
        #endregion
    }
}
