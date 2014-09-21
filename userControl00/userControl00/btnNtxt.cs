using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userControl00
{
    public partial class btnNtxt : UserControl
    {
        public string input {get; set;}
        private EventHandler performBtnConfirmClick { get; set; }

        public btnNtxt()
        {
            InitializeComponent();
        }

        public void SetBtnConfirmClickBehavior(EventHandler eventHandler)
        {
            performBtnConfirmClick = eventHandler;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // logic inside the control
            input = tbxInput.Text;

            // additional logic on the fly, such as logic from the host form
            performBtnConfirmClick(this, EventArgs.Empty);
        }
    }
}
