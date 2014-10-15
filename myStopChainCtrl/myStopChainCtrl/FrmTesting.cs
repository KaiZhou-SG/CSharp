using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FM.FMSystem.DAL;
using FM.TransportMaintenanceDLL.BLL;

namespace myStopChainCtrl
{
    public partial class FrmTesting : Form
    {
        public FrmTesting()
        {
            InitializeComponent();

            myStopChainCtrl1.LstAllStops = Stop.GetAllStops();
            myStopChainCtrl1.SelectedStops = new List<Stop>();
        }

        internal static void Main(string[] args)
        {
            args = new string[3];
            args[0] = "ipl";
            args[1] = "zhoukai\\sql2012";
            args[2] = "FM80_SG_WYN2KTRANSPORT";

            FMGlobalSettings.TheInstance.SetConnectionString(args);
            FMGlobalSettings.TheInstance.getConnectionString();

            Application.Run(new FrmTesting());
        }


    }
}
