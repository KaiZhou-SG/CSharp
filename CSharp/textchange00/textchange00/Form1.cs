using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textChange00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comBoBox1.Items.Add("Apple1");
            comBoBox1.Items.Add("Apple2");
            comBoBox1.Items.Add("Apple3");
            comBoBox1.Items.Add("Apple4");
            comBoBox1.Items.Add("Apple5");
            comBoBox1.Items.Add("Apple6");
            
        }

        private void comBoBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text_Changed");
        }

        private void comBoBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected_Index_Changed");
        }
    }
}
