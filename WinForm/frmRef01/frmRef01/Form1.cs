using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmRef01
{
    /// <summary>
    /// This program is going to test the a feature of reference:
    /// 1. Define a List of string: lstString
    /// 2. Define a string strTmp
    /// 3. Assign one element of lstString to strTmp, strTmp = lstString[i]
    /// 4. Modify strTmp, to see if lstString[i] is also modified(It's not, which means
    /// when we want to update the status of an element in a list, if we assign it to
    /// another object and updates that object, we need to use that object to replace 
    /// the element in the list finally)
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);

            strTmp = String.Empty;
            lstString = new List<string>();

            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0, n = 10;
            for (i = 0; i < n; i++)
            {
                lstString.Add(i.ToString());
            }

            strTmp = lstString[5];

            return;
        }

        #region "Private member variables"
        private string strTmp;
        private List<string> lstString;
        #endregion

        private void btnAddOneToStrTmp_Click(object sender, EventArgs e)
        {
            strTmp = "Add One";

            return;
        }
    }
}
