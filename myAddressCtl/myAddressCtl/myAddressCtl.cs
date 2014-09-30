﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.FMSystem.BLL;

namespace myAddressCtl
{
    /// <summary>
    /// 2014-09-30 Zhou Kai optimized this user 
    /// control, so that it has no dead loop of event
    /// handlers.
    /// The key point to avoid dead loop of event 
    /// handlers is: 
    /// (1) do only one thing in a function, or say 
    /// implement only one logic in a function. 
    /// (2) make sure the data flow is only one way 
    /// flow. For example, one possible data flow is:
    /// user input --> control.Text property 
    /// --> public property represent the control.Text
    /// property.
    /// You can't then add another dataflow:
    /// such as set public property in order to set the 
    /// Text property of a control.
    /// In that way, you got a dead loop.
    /// In stead, you can add a function solely for
    /// setting the Text property of that control:
    /// public void SetTbxName(string name);
    /// 
    /// </summary>
    public partial class myAddressCtl : UserControl
    {
        #region "Public properties"
        public string Code { get; private set; }
        public string _Name {get; private set;}
        public string Adr1 {get; private set;}
        public string Adr2  {get; private set;}
        public string Adr3 {get; private set;}
        public string Adr4 {get; private set;}
        public string City {get; private set;}
        private CustomerDTO current;
        public CustomerDTO Current 
        { get {return current;}
            private set
            {
                current = value;
                if (current != null)
                {
                    cboCode.Text = current.Code;
                    tbxName.Text = current.Name;
                    tbxAdr1.Text = current.address1;
                    tbxAdr2.Text = current.address2;
                    tbxAdr3.Text = current.address3;
                    tbxAdr4.Text = current.address4;
                    tbxCity.Text = current.city;
                }
                else
                {
                    cboCode.Text = String.Empty;
                    tbxName.Text = String.Empty;
                    tbxAdr1.Text = String.Empty;
                    tbxAdr2.Text = String.Empty;
                    tbxAdr3.Text = String.Empty;
                    tbxAdr4.Text = String.Empty;
                    tbxCity.Text = String.Empty;
                }
            }
        }
        private BindingSource bdsAddresses;
        public BindingSource BdsAddress
        {
            get {return bdsAddresses;}
            set
            {
                bdsAddresses = value;
                if (bdsAddresses != null)
                {
                    cboCode.DataSource = bdsAddresses;
                    cboCode.DisplayMember = "Code";
                }
            }
        }

        public void SetCode(string code)
        { cboCode.Text = code; }
        public void SetName(string name)
        { tbxName.Text = name; }
        public void SetAdr1(string adr1)
        { tbxAdr1.Text = adr1; }
        public void SetAdr2(string adr2)
        { tbxAdr2.Text = adr2; }
        public void SetAdr3(string adr3)
        { tbxAdr3.Text = adr3; }
        public void SetAdr4(string adr4)
        { tbxAdr4.Text = adr4; }
        public void SetCity(string city)
        { tbxCity.Text = city; }

        #endregion

        #region "Constructors"
        public myAddressCtl()
        {
            InitializeComponent();

        }

        #endregion

        #region "Event handlers"
        public event EventHandler OnInitializeCodes;
        public event EventHandler OnCodeChanged;

        private void cboCode_TextChanged(
            object sender, EventArgs e)
        {
            // the client assign an event handler to this event
            // via assign a function to the delegate below:
            if (OnCodeChanged != null)
            {
                // the client has assigned function to this 
                // event
               OnCodeChanged(this, EventArgs.Empty);
            }
            else
            {
                // the client hasn't assign a function to this 
                // event.
                // perform default logic
                CodeChanged(sender, e);
            }
            
        }

        // the default logic to handle the code_changed event
        private void CodeChanged(object sender,
            EventArgs e)
        {
            Code = cboCode.Text;
            if (Code != String.Empty)
            {
                current = 
                  (CustomerDTO)cboCode.SelectedItem;
                Current = current;
            }
            else { current = null; }

        }

        // control logic
        private void tbxName_TextChanged(
            object sender, EventArgs e)
        {
            Name = tbxName.Text;
        }

        private void tbxAdr1_TextChanged(
            object sender, EventArgs e)
        {
            Adr1 = tbxAdr1.Text;
        }

        private void tbxAdr2_TextChanged(
            object sender, EventArgs e)
        {
            Adr2 = tbxAdr2.Text;
        }

        private void tbxAdr3_TextChanged(
            object sender, EventArgs e)
        {
            Adr3 = tbxAdr3.Text;
        }

        private void tbxAdr4_TextChanged(
            object sender, EventArgs e)
        {
            Adr4 = tbxAdr4.Text;
        }

        private void tbxCity_TextChanged(
            object sender, EventArgs e)
        {
            City = tbxCity.Text;
        }
        // end of control logic

        #endregion 

    }
}
