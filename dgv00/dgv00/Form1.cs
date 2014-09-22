using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dgv00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, 
            EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, 
            EventArgs e)
        {
            List<Employee> lstEmployee = 
                new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                lstEmployee.Add(
                    new Employee("Name " + i.ToString(), i,
                                            Gender.Male));

                BindingSource bdsEmployees = new BindingSource();
                bdsEmployees.DataSource = lstEmployee;
                dataGridView1.DataSource = bdsEmployees;
            }

            //List<string> lstGrades = new List<string>();
            //lstGrades.Add("1");
            //lstGrades.Add("2");
            //lstGrades.Add("3");

            //BindingSource bdsGrade = new BindingSource();
            //bdsGrade.DataSource = lstGrades;
            //Column1.DataSource = bdsGrade;

            for (int i = 0; i < Column1.Items.Count; i++)
            {
                MessageBox.Show(Column1.Items[i].ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
