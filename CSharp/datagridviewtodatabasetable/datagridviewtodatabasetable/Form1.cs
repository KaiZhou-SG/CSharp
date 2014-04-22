using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridViewtoDatabaseTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.schoolSystemDataSet.Students);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the changed values to Database Table
            this.studentsTableAdapter.Update(this.schoolSystemDataSet.Students);
        }


    }
}
