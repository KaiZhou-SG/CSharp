using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEvents00
{
    // 2014-01-05 Zhou Kai writes class to learn and practice
    // events
    public partial class Form1 : Form
    {
        #region "Private member variables"
        private bool isButtonClicked;
        #endregion

        #region "Events and event handlers"
        public event EventHandler ButtonSayHelloClicked;

        protected virtual void OnButtonSayHelloClicked()
        {
            if (ButtonSayHelloClicked != null)
            {
                ButtonSayHelloClicked(this, EventArgs.Empty);
            }
        }

        private void DelegateFun(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void tmrSayHello_Tick(object sender, EventArgs e)
        {
            button1.Text = System.DateTime.Now.Minute / 2 == 0 ? "Time to say hello." : String.Empty;
            // modify the property to raise the event
            IsButtonClicked = button1.Text.Equals(String.Empty) ? true : false;
        }
        #endregion

        #region "Constructors"
        public Form1()
        {
            InitializeComponent();

            // initialize the timer
            tmrSayHello.Interval = 5000; // 5 seconds
            tmrSayHello.Start();
            isButtonClicked = false;
            // register the function to the event handler
            // ButtonSayHelloClicked += OnButtonSayHelloClicked;
            ButtonSayHelloClicked += DelegateFun;
        }
        #endregion

        #region "Raise the button clicked event"
        public bool IsButtonClicked
        {
            get
            {
                return button1.Text.Equals(String.Empty);
            }
            set
            {
                isButtonClicked = value;
                // handler the event
                OnButtonSayHelloClicked();
            }
        }
        #endregion


    }
}
