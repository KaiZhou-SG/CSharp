using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDragDrop03
{
    public partial class Form1 : Form
    {
        #region "variables"
        private Truck truck;
        private List<Truck> lstTrucks;
        #endregion

        #region "constructors"
        public Form1()
        {
            InitializeComponent();
            truck = new Truck();
            lstTrucks = new List<Truck>();

            // can only set allow-drop by code
            groupBox1.AllowDrop = true;
        }
        #endregion

        #region ""

        #endregion

        #region "event handlers"
        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            truck = new Truck(tbxTrNo.Text, tbxDriverName.Text, 
                tbxDriverLicense.Text, tbxTruckCondition.Text);
            lsvTruck.Items.Add(truck.ToString());
        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            string truck_info = e.Data.GetData(DataFormats.Text).ToString();
            // avoid this kind of hard codes
            tbxTrNo.Text = truck_info.Split(',')[0].Split(' ')[1];
            tbxDriverName.Text = truck_info.Split(',')[1].Split(' ')[2];
            tbxDriverLicense.Text = truck_info.Split(',')[2].Split(' ')[2];
            tbxTruckCondition.Text = truck_info.Split(',')[3].Split(' ')[2];
        }

        private void lsvTruck_MouseDown(object sender, MouseEventArgs e)
        {
            if (lsvTruck.SelectedItems.Count > 0)
            {
                lsvTruck.DoDragDrop(lsvTruck.SelectedItems[0].Text, DragDropEffects.Copy);
            }
        }

        private void groupBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void tbxTrNo_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("You're dropping something.");
            string truck_info = sender as string;
            // avoid this kind of hard codes
            tbxTrNo.Text = truck_info.Split(',')[0].Split(' ')[1];
            tbxDriverName.Text = truck_info.Split(',')[1].Split(' ')[1];
            tbxDriverLicense.Text = truck_info.Split(',')[2].Split(' ')[1];
            tbxTruckCondition.Text = truck_info.Split(',')[3].Split(' ')[1];
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lsvTruck_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion



        
    }
}
