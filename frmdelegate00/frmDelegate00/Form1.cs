using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDelegate00
{
    /// <summary>
    /// 2014-01-07 Zhou Kai writes this project to learn the concepts of "delegate"
    /// </summary>

    public partial class Form1 : Form
    {
        #region "Private members"
        private string txt;
        // delSpeak is like an event
        private MakeSound delSpeak;
        #endregion

        #region "Public properties"
        public new /*override*/ string Text
        {
            get { return txt; }
            set
            {
                // raise and handler the event
                txt = value;
                delSpeak(value);
            }
        }
        #endregion

        #region "Constructors"
        public Form1()
        {
            // Register the event with event handler
            delSpeak = Speak;

            InitializeComponent();
        }
        #endregion

        #region "Private member variables"
        // define a delegate is like defining an new event
        private delegate void MakeSound(string sound);
        #endregion

        #region "Methods"
        // Speak is like an event handler
        private void Speak(string sound)
        {
            MessageBox.Show(sound);
        }
        #endregion

        private void tbxEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEvent_Validating(object sender, CancelEventArgs e)
        {
            // check if the text is changed
            TextBox tb = sender as TextBox;
            if (txt.Equals(tb.Text))
            {
                // text not changed
            }
            else
            {
                // text changed, raise the delSpeak event
                Text = tb.Text;
            }
        }

        private void tbxEvent_Validated(object sender, EventArgs e)
        {
            // occurs after text is validated
        }
    }
}
