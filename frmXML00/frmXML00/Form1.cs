using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmXML00
{
    public partial class Form1 : Form
    {
        #region ""
        public Form1()
        {
            InitializeComponent();

            // the default index sequence of the data grid view
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DisplayIndex = i;
            }
            
        }

        #endregion

        #region "Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            FillInDataGridView();
        }

        #endregion

        #region "Methods"
        private void FillInDataGridView()
        {
            Country country = new Country();
            BindingSource bdsCountries = new BindingSource();
            List<Country> lstCountries = country.GetAllCountries();
            bdsCountries.DataSource = lstCountries;
            dataGridView1.DataSource = bdsCountries;

        }

        #endregion

    }
}
