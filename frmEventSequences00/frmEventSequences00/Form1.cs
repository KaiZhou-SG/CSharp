using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace frmEventSequences00
{
    public partial class Form1 : Form
    {
        public static int nEventIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Form1_Load: {0}", nEventIndex));
            Trace.WriteLine(String.Format("Form1_Load: {0}", nEventIndex));
            nEventIndex++;

            // add binding source to the combobox
            BindingSource bdsStudents = new BindingSource();
            // Although add a blank string here, it still trigger the index_changed and text_changed  event
            // when assigning binding source to teh data source of the combobox control.
            Student.lstStudents.Add(new Student()); 
            Student.lstStudents.Add(new Student("Zhou Kai"));
            Student.lstStudents.Add(new Student("Liu Yaqiao"));
            Student.lstStudents.Add(new Student("Liu Chang"));
            Student.lstStudents.Add(new Student("Dong He"));
            bdsStudents.DataSource = Student.lstStudents; // this will trigger index_changed and text_changed event
            comboBox1.DataSource = bdsStudents;
            comboBox1.DisplayMember = "SName"; // this will trigger index_changed and text_changed event again
            MessageBox.Show(String.Format("Adding binding source: {0}", nEventIndex));
            Trace.WriteLine(String.Format("Adding binding source: {0}", nEventIndex));
            nEventIndex++;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("comboBox1_TextChanged: {0}", nEventIndex));
            Trace.WriteLine(String.Format("comboBox1_TextChanged: {0}", nEventIndex));
            nEventIndex++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("comboBox1_SelectedIndexChanged: {0}", nEventIndex));
            Trace.WriteLine(String.Format("comboBox1_SelectedIndexChanged: {0}", nEventIndex));
            nEventIndex++;
        }
    }
}
