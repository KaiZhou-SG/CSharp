using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Students;

namespace databinding01
{
    public partial class Form1 : Form
    {
        private blStudents bindingListStudents;

        public Form1()
        {
            InitializeComponent();
            bindingListStudents = new blStudents();
            dataGridView1.DataSource = bindingListStudents;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student(1, "Zhou Kai", enumGender.Male, 26, 9);
            bindingListStudents.Add(stu);
        }

        void button3_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
