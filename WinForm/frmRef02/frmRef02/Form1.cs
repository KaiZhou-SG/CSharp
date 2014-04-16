using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmRef02
{
    /// <summary>
    /// 2014-04-16 Zhou Kai writes this program to:
    /// test a feature of reference:
    /// (1) Define two reference type variables: string str1, string str2;
    /// (2) Change the value of str1, and check if str2 is also changed(no, str2 is not changed)
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.Load +=new EventHandler(Form1_Load);
            this.btnChangeToHello.Click += new EventHandler(btnChangeToHello_Clicked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            str1 = "I'm str1.\n";
            str2 = "I'm str2.\n";
        }

        private void btnChangeToHello_Clicked(object sender, EventArgs e)
        {
            str1 = str2; // this makes the contents of str1 equals that of str2
            // modify str2, but str1 remains unchanged
            str2 = "I'm str2, changed. Let's see what comes to str1.";
            // now modify str1 to see what happens to str2, str2 is unchanged
            str1 = "I'm str1, changed. Let's see what comes to str2.";
        }

        #region "Private member variables"
        private string str1, str2;
        #endregion
    }
}
