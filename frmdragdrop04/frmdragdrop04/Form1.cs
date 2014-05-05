using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDragdrop04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (tbxSource.Text.Length > 0)
            {
                tbxSource.DoDragDrop(tbxSource.Text, DragDropEffects.Copy);
            }
        }

        private void tbxTarget_DragDrop(object sender, DragEventArgs e)
        {
            tbxTarget.Text = e.Data.GetData(DataFormats.Text).ToString();    
        }

        private void tbxTarget_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }   
}
