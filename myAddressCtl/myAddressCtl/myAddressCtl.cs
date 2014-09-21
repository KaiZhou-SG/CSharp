using System;
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
    public partial class myAddressCtl : UserControl
    {
        #region "Public properties"
        public string Code { get; private set; }
        public string _Name { get; private set; }
        public string Adr1 { get; private set; }
        public string Adr2 { get; private set; }
        public string Adr3 { get; private set; }
        public string Adr4 { get; private set; }
        public string City { get; private set; }
        public CustomerDTO current { get; private set; }
        public BindingSource bdsAddresses { get; set; }

        #endregion

        #region "Expose events to the control user"
        public event EventHandler OnInitializeCodes;
        public event EventHandler OnCodeChanged;

        #endregion

        #region "Constructors"
        public myAddressCtl()
        {
            InitializeComponent();

            Code = String.Empty;
            _Name = String.Empty;
            Adr1 = String.Empty;
            Adr2 = String.Empty;
            Adr3 = String.Empty;
            Adr4 = String.Empty;
            City = String.Empty;

            bdsAddresses = new BindingSource();
            cboCode.DataSource = bdsAddresses;
            cboCode.DisplayMember = "Code";

            current = null;
            OnInitializeCodes = null;
            OnCodeChanged = null;

        }

        #endregion

    }
}
