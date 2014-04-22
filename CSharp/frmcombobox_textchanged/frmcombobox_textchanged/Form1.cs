using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCombobox_TextChanged
{
    /// <summary>
    /// 2014-02-07 Zhou Kai writes this program to check if the 
    /// TextChanged event will be triggered when the Text property
    /// of a combobox is changed by changing its datasource
    /// </summary>
    public partial class Form1 : Form
    {
        private ComboBox cobBox1;
        private Button button1;
        private Button button2;
        private string cobText;
        public string CobText
        {
            get { return cobText; }
            set 
            { 
                cobText = value;
            }
        }
        private  string [] nameListA= {"NameA", "NameA1", "NameA2"};
        private string[] nameListB = {"NameB", "NameB1", "NameB2"};

        public Form1()
        {
            InitializeComponent();
            cobBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            this.Controls.Add(cobBox1);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            cobBox1.Dock = DockStyle.Bottom;
            button1.Dock = DockStyle.Top;
            button2.Dock = DockStyle.Top;
            // Note here:
            // Need to set DataSourceUpdateMode to OnPropertyChanged for combobobx, however, for TextBox, no need
            // to set that for its Text property. Why?
            cobBox1.DataBindings.Add(new Binding("Text", this, "CobText", false, DataSourceUpdateMode.OnPropertyChanged));
            
            cobBox1.TextChanged += cobBox1_TextChanged;
            button1.Click += button1_Click;
            button2.Click += button2_Click;

            button1.Text = "Change Datasource to ListA";
            button2.Text = "Change Datasource to ListB";
        }

        private void cobBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("My Text property is changed, now CobTxt = {0}, and Text = {1}.", CobText, cobBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cobBox1.DataSource = nameListA;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cobBox1.DataSource = nameListB;
        }
    }
}
