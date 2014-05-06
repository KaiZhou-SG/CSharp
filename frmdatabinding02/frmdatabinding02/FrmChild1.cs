using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDatabinding02
{
    public partial class FrmChild1 : Form
    {
        #region "Public properties"
        public string Username
        {
            get { return tbxUsername.Text; }
            set { tbxUsername.Text = value; }
        }

        public string Password
        {
            get { return tbxPassword.Text; }
            set { tbxPassword.Text = value; }
        }
        #endregion

        #region "Constructors"
        public FrmChild1(string userName, string passWord)
        {
            InitializeComponent();

            // databinding
            tbxUsername.DataBindings.Add(new Binding("Text", this, "Username"));
            tbxPassword.DataBindings.Add(new Binding("Text", this, "Password"));
        }
        #endregion

        #region "Public methods"
        public void UpdateInfo(string userName, string passWord)
        {
            // use binding to update control property 
            Username = userName;
            Password = passWord;
        }
        #endregion

    }
}
