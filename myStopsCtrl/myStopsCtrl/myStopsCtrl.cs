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

namespace myStopsCtrl
{
    public partial class myStopsCtrl : UserControl
    {
        // store a stop temporarily
        private CustomerDTO tmpStop; 
        private BindingSource bdsStops;
        public BindingSource BdsStops
        {
            get { return bdsStops; }
            set
            {
                bdsStops = value;
                dgvStops.DataSource = bdsStops;
            }
        }
        // bdsAllStops will be initialized only when the
        //  user clicks Add, and will be initialized only 
        // once
        public BindingSource bdsAllStops;
        public myStopsCtrl()
        {
            InitializeComponent();
        }

        private bool MoveUp(int index)
        {
            if (index > 0 && index < bdsStops.Count)
            {
                var tmp = bdsStops[index];
                bdsStops[index] = bdsStops[index - 1];
                bdsStops[index - 1] = tmp;
                BdsStops = new BindingSource() { DataSource = bdsStops };

                return true;
            }
            
            return false;
        }

        private bool MoveDown(int index)
        {
            if (index >= 0 && index < bdsStops.Count - 1)
            {
                var tmp = bdsStops[index];
                bdsStops[index] = bdsStops[index + 1];
                bdsStops[index + 1] = tmp;
                BdsStops = new BindingSource() { DataSource = bdsStops };

                return true;
            }

            return false;
        }

        private bool Delete(int index)
        {
            if (index >= 0 && index < bdsStops.Count)
            {
                bdsStops.RemoveAt(index);
                BdsStops = new BindingSource() { DataSource = bdsStops };

                return true;
            }

            return false;
        }

        private bool Add(CustomerDTO stop)
        {
            // initialize only once
            if (bdsAllStops == null)
            {
                throw new Exception(
                    "Please provide all possible stops for"
                + " the user to choose from");
            }

            FrmStop frmStop = new FrmStop(bdsAllStops);
            frmStop.ShowDialog();
            tmpStop = frmStop.GetSelectedStop();

            // only add when the user selected a valid stop
            if (tmpStop != null) { bdsStops.Add(tmpStop); }
            frmStop.Close();
            frmStop.Dispose();

            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(tmpStop);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvStops.SelectedRows.Count == 1)
            {
                int index = dgvStops.SelectedRows[0].Index;
                Delete(index);
                BdsStops = new BindingSource(){DataSource = bdsStops};
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvStops.SelectedRows.Count == 1)
            {
                int index = dgvStops.SelectedRows[0].Index;
                if (MoveUp(index))
                {
                    dgvStops.Rows[index - 1].Selected = true;
                }
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvStops.SelectedRows.Count == 1)
            {
                int index = dgvStops.SelectedRows[0].Index;
                if (MoveDown(index))
                {
                    dgvStops.Rows[index + 1].Selected = true;
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dgvStops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStops.SelectedCells[0].RowIndex;
            dgvStops.Rows[index].Selected = true;
        }

        private void dgvStops_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgvStops.SelectedRows[0].Index;
            dgvStops.Rows[index].Selected = true;
        }

    }
}
