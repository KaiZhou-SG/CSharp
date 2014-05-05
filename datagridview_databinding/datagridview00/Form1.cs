using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Datagridview00
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Student stu1 = new Student("Kai Zhou", Gender.male, 26);
            Student stu2 = new Student("Shiyang Liu", Gender.femal, 25);
            Student stu3 = new Student("Yaqiao Liu", Gender.femal, 25);

            Students stuList = new Students();
            stuList.Add(stu1);
            stuList.Add(stu2);
            stuList.Add(stu3);

            bindingSourceStudents.DataSource = stuList;
            bindingSourceStudents.ResetBindings(false);
        }


    }
}
