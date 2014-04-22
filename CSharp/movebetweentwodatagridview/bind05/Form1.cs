using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bind05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studentsLeft = new List<Student>();
            studentsRight = new List<Student>();
            bindSourceStudentsLeft = new BindingSource();
            bindSourceStudentsRight = new BindingSource();
            bindSourceStudentsLeft.DataSource = studentsLeft;
            bindSourceStudentsRight.DataSource = studentsRight;
            dgvStudentsLeft.DataSource = bindSourceStudentsLeft;
            dgvStudentsRight.DataSource = bindSourceStudentsRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            studentsLeft.Add(stu);
            bindSourceStudentsLeft.ResetBindings(false);
        }

        private List<Student> studentsLeft;
        private List<Student> studentsRight;
        private BindingSource bindSourceStudentsLeft;
        private BindingSource bindSourceStudentsRight;

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            //move selected one or more student to the list to the left
            if (dgvStudentsRight.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.");

            }
            else if (dgvStudentsRight.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow rowSelected in dgvStudentsRight.SelectedRows)
                {
                    //add the selected student(s) to the right list first
                    Student selectedRowStudent = (Student)rowSelected.DataBoundItem;
                    studentsLeft.Add(selectedRowStudent);
                    bindSourceStudentsLeft.ResetBindings(false);    
                    //then remvoe the selected student(s) on the left list
                    Student tmp;
                    tmp = studentsRight.Find(student => student.Name.Equals(selectedRowStudent.Name));
                    studentsRight.Remove(tmp);
                    bindSourceStudentsRight.ResetBindings(false);
                }
            }

            return;
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            //move selected one or more student to the list to the right
            if (dgvStudentsLeft.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.");

            }
            else if (dgvStudentsLeft.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow rowSelected in dgvStudentsLeft.SelectedRows)
                {
                    //add the selected student(s) to the right list first
                    Student selectedRowStudent = (Student)rowSelected.DataBoundItem;
                    studentsRight.Add(selectedRowStudent);
                    bindSourceStudentsRight.DataSource = studentsRight;
                    bindSourceStudentsRight.ResetBindings(false);

                    //then remvoe the selected student(s) on the left list
                    Student tmp;
                    tmp = studentsLeft.Find(student => student.Name.Equals(selectedRowStudent.Name));
                    studentsLeft.Remove(tmp);
                    
                    bindSourceStudentsLeft.ResetBindings(false);
                }
            }

        }

        #region "Methods"
 


        #endregion
    }

    public class Student
    {
        public static Int32 id;
        public string name;
        public Int32 age;
        public string gender;
        
        [Browsable(false)]
        public Int32 ID
        {
            get { return id; }
            private set { }
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set { }
        }
        public Int32 Age
        {
            get
            {
                return age;
            }
            private set { }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            private set { }
        }

        public Student()
        {
            name = @"default";
            age = 0;
            gender = @"male";
        }
    }
}
