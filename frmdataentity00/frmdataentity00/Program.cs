using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDataEntity00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void Test()
        {
            BasicInfoTbl tblBasicInfo = new BasicInfoTbl();
            WEBHOMEEntities dbWebHome = new WEBHOMEEntities();
            
            return;
        }
    }
}
