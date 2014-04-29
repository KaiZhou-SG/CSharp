using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Students;
using System.Xml;

namespace DragDrop02
{
    public partial class Form1 : Form
    {
        private blStudents lstStudents; // binding list of student
        private Int32 stuId;
        private string strTmp;

        public Form1()
        {
            InitializeComponent();

            stuId = 0;
            strTmp = " Loves Life";
            lstStudents = new blStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdsStudents.DataSource = lstStudents;
            listBox1.DisplayMember = @"ID";
            listBox1.ValueMember = @"Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstStudents.Add(CreateStudent());
        }

        private Student CreateStudent()
        {
            Student stu = new Student(stuId, "Zhou Kai" + strTmp, enumGender.Male, 26, 9);
            stuId++;
            try
            {
                strTmp += strTmp;
            }
            catch (OutOfMemoryException oe)
            {
                strTmp = String.Empty;
            }
            
            return stu;
        }

        private void bdsStudents_AddingNew(object sender, AddingNewEventArgs e)
        {
            MessageBox.Show("new item added to the binding source");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                MessageBox.Show(listBox1.SelectedValue.ToString());
            }
        }

        #region "Drag-Drop"
        /*
         * To implement a drag-drop operation, there're 3 steps at least:
         * SourceControl.DoDragDrop(means start drag-drop) --> TargetControl.DragEnter() --> TargetControl.DragDrop()
         * 
         * (1) To start the drag-drop, via invoking ControlToDragFrom.DoDragDrop()
         * (2) When item dragged into the target control, validate the dragged data
         *     via invoking TargetControl_DragEnter_EventHandler()
         * (3) Drop to the target control, via invoking TargetControl_DragDrop(),
         *     get the data dragged from the ControlToDragFrom, and perform
         *     some operation towards it
         * (4) Another important thing to be noted: DragDropEffects should be set to
         *     value other than "None", otherwise, the drag-drop will not work.
         */

        // source_control.DoDragDrop()
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedValue.ToString(), DragDropEffects.Copy); // effect is Copy here
        }

        // target_control.dragEnter()
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                // If I comment out the line below,
                // the drag-drop will not work.
                // Another thing to notice is that:
                // The DragDropEffects in DoDragDrop() should 
                // be the same with that of the DragEnter() method, 
                // otherwise, cannot drag-drop is not allowed.
                e.Effect = DragDropEffects.Copy; // should be Copy
            }
        }

        // target_control.Dragdrop()
        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the data been draged 
            string txt = e.Data.GetData(DataFormats.StringFormat) as string;
            label1.Text += txt + "\n";
        }
        #endregion
    }

}
