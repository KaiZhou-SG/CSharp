using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTextbox_TextChanged
{
    /// <summary>
    ///  2014-02-07 Zhou Kai writes this program to test the databinding of
    ///  Textbox, to see if I need to set DataSourceUpdateMode.OnPropertyChanged
    ///  explicitly.
    ///  
    ///  Conclusion: Unlike Combobox, TextBox does not need to set
    ///  DataSourceUpdateMode.OpropertyChanged explicitly
    /// </summary>
    
    public partial class Form1 : Form
    {
        private string txt;
        private TextBox textBox1;
        private Button button1;
        
        public string Txt
        {
            get { return txt; }
            set 
            {
                txt = value; 
                textBox1.Text = txt; // sync back, from business object to UI
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox1.Text = "";
            textBox1.DataBindings.Add("Text", this, "Txt"); // sync, from UI to business object
            button1.Text = "Change to Bind Name B";
            button1.Click += button1_Click;

            textBox1.Dock = DockStyle.Top;
            button1.Dock = DockStyle.Bottom;
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
        }

        void button1_Click(object sender, EventArgs e)
        {
            Txt = "NameB";
        }


    }
}
