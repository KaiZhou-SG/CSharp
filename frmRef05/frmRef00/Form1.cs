﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

///<summary>
/// This namespace is for a windows form Form1 only
///</summary>
namespace frmRef00
{
    /// <summary>
    /// Author: Zhou Kai 
    /// Date: 2014-04-17 
    /// Replace all the String to StringBuilder to test again.
    /// The codes are the same with the project frmRef00, only
    /// replaces String type to StringBuilder type
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// 
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            this.bdsStrList.CurrentChanged += new EventHandler(bdsStrList_CurrentChanged);

            lstStringBuilders = new List<StringBuilder>();
            sbCurrent = new StringBuilder();

            return;
        }

        ///<summary>
        ///Form load event: 
        ///(1) Assign values to datasource: lstString
        ///(2) Assign lstString to bdsStrList(defined on UI)
        ///(3) Bind bdsStrList to lbStrList
        ///(4) Assign bdsStrList.current to strCurrent
        ///</summary>
        ///
        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0, j = 10;
            for (i = 0; i < j; i++)
            {
                lstStringBuilders.Add(new StringBuilder(i.ToString()));
            }

            bdsStrList.DataSource = lstStringBuilders;
            lbStrList.DataSource = bdsStrList;
            sbCurrent = (StringBuilder)bdsStrList.Current;

            return;
        }

        #region "Private member variables"
        ///<remarks>
        ///lstString serves as the datasource, it's going to be 
        ///assigned to a binding source bdsStrList, and bdsStrList
        ///will be bind to the ListBox control lbStrList on this form.
        ///
        ///strCurrent serves as the current string:
        ///ctrCurrent = bdsStrList.current;
        ///</remarks>
        private List<StringBuilder> lstStringBuilders;
        private StringBuilder sbCurrent;

        #endregion

        /// <summary>
        /// The button click event will cause the strCurrent to "Add 1", for example,
        /// if strCurrent is 1, after this event, strCurrent becomes 2.
        /// </summary>
        /// <exception cref="System.Exception">Throw when failed while parsing a string to integer.</exception>
        private void btnAddOneToStrCurrent_Click(object sender, EventArgs e)
        {
            int current = 0;

            if (Int32.TryParse(sbCurrent.ToString(), out current))
            {
                sbCurrent.Remove(0, sbCurrent.Length);
                sbCurrent.Append((current + 1).ToString());
                bdsStrList.ResetBindings(false);
            }
            else
            {
                throw new Exception("Failed while parsing a string to integer.\n");
            }

            return;
        }

        /// <summary>
        /// When the selected item is changed, assign the new 
        /// item to strCurrent
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event argument</param>
        private void bdsStrList_CurrentChanged(object sender, EventArgs e)
        {
            sbCurrent = (StringBuilder)bdsStrList.Current;

            return;
        }
    }
}
