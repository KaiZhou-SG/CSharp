using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystem.SystemGlobals;
using System.Data;
using System.Data.SqlClient;

namespace SchoolSystem.Login
{
    public partial class FrmWelcome : Form
    {
        #region "Private Member Variables"
        private string userName;
        private string passWord;

        #endregion

        public FrmWelcome()
        {
            InitializeComponent();
        }

        #region "Event Handlers"
        // 2013-12-03 Zhou Kai adds
        private void btnLogin_Click(object sender, EventArgs e)
        {
                            
        }
        #endregion

        #region "Methods"
        private bool IsAllInfoComplete()
        {
            return (!(tbxUsername.Text.Equals(String.Empty) ||
                mtbPassword.Text.Equals(String.Empty)));
        }
        #endregion


    }
}
