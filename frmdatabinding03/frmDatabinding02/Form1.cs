using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDatabinding03
{
    /// <summary>
    /// 2014-02-02 Zhou Kai writes this program to learn
    /// and practice the concepts of databindging and events.
    /// 
    /// Program description:
    /// 1. The Text property of TextBox1 is bind to a public property of Form1 called TbxText.
    /// so, when the Text property of TextBox1 changes, TbxText changes
    /// 3. Whenever the TbxText changes, notify the TextBox1 to change its Text property 
    /// according to that change
    /// 
    /// Solutions:
    /// 1. Bind the Text property of TextBox to the datasource / bidingsource TbxText
    /// 2. Write an event OnTbxText_Changed, and an event handler TbxText_Changed.
    /// Whenver the TbxText changes, OnTbxText_Changed event will be raised,
    /// and event handler TbxText_Changed will be invoked.
    /// </summary>
    public partial class Form1 : Form
    {
        #region "Private member variables"
        private string tbxText;
        #endregion

        #region "Public properties"
        public string TbxText
        {
            get
            {
                return tbxText;
            }
            set
            {
                tbxText = value;
                // raise the OnTbxText_Changed event
                OnTbxText_Changed(this, EventArgs.Empty);
            }
        }
        #endregion

        #region "Event and Event handlers"
        public event EventHandler OnTbxText_Changed;

        private void TbxText_Changed(object sender, EventArgs e)
        {
            // there's a bug: 
            // the EventArgs is empty, and the event data is not passed
            // from the parameters of the event handler.
            // The better solution is:
            // write a custom MyEventArgs and pass the TbxText value
            // with that MyEventArgs
            textBox1.Text = TbxText;    
        }
        #endregion

        #region "Constructors"
        public Form1()
        {
            InitializeComponent();
            // bind the Text property to bindgsource TbxText property
            textBox1.DataBindings.Add(new Binding("Text", this, "TbxText"));
        }
        #endregion
    }
}
