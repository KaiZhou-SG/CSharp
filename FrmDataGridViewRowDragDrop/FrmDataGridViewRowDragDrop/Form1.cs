using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDataGridViewRowDragDrop
{
    /// <summary>
    /// The Form1 class, it represents the main form of this program
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            Form2 form2 = new Form2();
            lstApples = new List<Apple>();
            bdsLstApples = new BindingSource();
            this.refresh();
            form2.Show();
        }

        private List<Apple> lstApples;

        /// <summary>
        /// Refresh this class(form)
        /// </summary>
        /// <returns>returns false when exception happens</returns>
        private bool refresh()
        {
            try
            {
                initializeLstApple();
                initializeDataGridView1();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Initialize DataGridView1
        /// </summary>
        private void initializeDataGridView1()
        {
            bdsLstApples.DataSource = lstApples;
            dataGridView1.DataSource = bdsLstApples;
        }

        /// <summary>
        /// Refresh dataGridView1, set the rows to ReadOnly when
        /// they represents an apple which is invailable.
        /// </summary>
        private void refreshDataGridView1()
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (!((Apple)dgvr.DataBoundItem).isAvailable)
                {
                    dgvr.ReadOnly = true;
                }
            }
        }

        /// <summary>
        /// Initialize the lstApples
        /// </summary>
        private void initializeLstApple()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                this.lstApples.Add(new Apple("apple" + i, "China", (decimal)i, true));
            }
        }

        #region "Fields"
        /// <summary>
        /// The BindingSource for dataGridView1,
        /// its datasource is lstApples
        /// </summary>
        private BindingSource bdsLstApples;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Apple apple = (Apple)bdsLstApples.Current;
            apple.isAvailable = false;

            refreshDataGridView1();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            int nRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            Apple selectedApple = (Apple)dataGridView1.Rows[nRowIndex].DataBoundItem;

            if (!object.ReferenceEquals(selectedApple, null))
            {
                // MessageBox.Show(String.Format("Row {0} is of ReadOnly: {1}.", nRowIndex, dataGridView1.Rows[nRowIndex].ReadOnly));
                MessageBox.Show(dataGridView1.DoDragDrop(selectedApple.ToString(), DragDropEffects.Copy).ToString());
            }
            else
            {
                MessageBox.Show("Please select an apple before dragging");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
        }
    }
}
