using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDatabinding00
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 2014-02-02 Zhou Kai writes this program to 
        /// learn and practice the concepts of databinding.
        /// 
        /// There're two textboxes, the text of the second textbox
        /// will change while that of the first textbox changes.
        /// 
        /// 1. The text property of the first textbox is bind to a public 
        ///     property: TbxText. So when the text of  the first textbox
        ///     changed, the TbxText is automatically changed.
        /// 2. Each time TbxText is changed, it will 
        ///     NOTIFY the second textbox to change its text property 
        ///     according to that change.
        /// </summary>
        /// 

        #region "Private member variables"
        private string tbxText; 
        #endregion

        #region "Public properties"
        public string TbxText // public property, serve as binding source
        {
            get { return tbxText; }
            set 
            {
                tbxText = value;
                MyEventArgs e = new MyEventArgs(value);
                // Raise event
                OnTbxTextChanged(this.TbxText, e);
            }
        }
        #endregion

        #region "Constructors"

        public Form1()
        {
            InitializeComponent();
            // Register event handlers
            this.Load += Form1_Load;
            OnTbxTextChanged = TbxTextChanged;
        }
        #endregion

        #region "Define events"
        // public event EventHandler TextChanged;
        public delegate void DelOnTbxTextChanged(object sender, MyEventArgs e);
        public DelOnTbxTextChanged OnTbxTextChanged;
        // custom event args
        public  EventArgs MyEventArgs; 
       
        #endregion

        #region "Event handlers"
        private void Form1_Load(object sender, EventArgs e)
        {
            // databinding
            textBox1.DataBindings.Add(new Binding("Text", this, "TbxText"));
            return;
        }

        // Event handler
        private void TbxTextChanged(object sender, MyEventArgs e)
        {
            textBox2.Text = e.newText;
        }
        #endregion
    }

    #region "Custom event args"
    public class MyEventArgs : EventArgs
    {
        public string newText;

        public MyEventArgs(string newText)
        {
            this.newText = newText;
        }
    }
    #endregion
}
