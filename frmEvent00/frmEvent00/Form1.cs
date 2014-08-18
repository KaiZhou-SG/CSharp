using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEvent00
{
    /// <summary>
    /// 2014-08-18 Zhou Kai writes this program to
    /// demostrate the "sender" argument of the event
    /// handler:
    /// we can use the "sender" argument to provide 
    /// information from the event trigger to the event
    /// handler which is useful.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // routine the event handler to the control
            button1.Click += button1_clicked;
            button2.Click += button2_clicked;
        }

        internal static int nClickedTimes = 0;

        // write the event handler, or let the vs_designer
        // to generate it, both OK
        private void button1_clicked(object sender,
            EventArgs e)
        {
            // make use of the information the event 
            // trigger distributed.
            // when this event is triggered the 3rd time,
            // the message box will appear.
            if (sender.ToString().Equals("3"))
            {
                MessageBox.Show("OK, now I'm "
                + "clicked 3 times, time to do something");
            }
        }

        // when the button2 is clicked the button1 
        // clicked event is triggered.
        private void button2_clicked(object sender,
            EventArgs e)
        {
            ++nClickedTimes;
            button1_clicked(nClickedTimes.ToString(), 
                EventArgs.Empty);
            
        }

    }
}
