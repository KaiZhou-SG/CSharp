using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trycatch01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal num1 = 0m, num2 = 0m;
            const string message = "Input numbers are valid.";

            if (!(Decimal.TryParse(tbxNum1.Text, out num1) &&
                  Decimal.TryParse(tbxNum2.Text, out num2)))
            {
                MessageBox.Show(message);
                return;
            }
            else
            {
                try
                {
                    tbxRes.Text = Convert.ToString(Divide(num1, num2));
                }
                catch (DivideByZeroException idobEx)
                {
                    MessageBox.Show("Error caught from parent function.");
                }
            }
        }

        private decimal Divide(decimal num1, decimal num2)
        {
            try
            {
                return (num1 / num2);
            }
            catch (/* DivideByZeroException idobEx */ IndexOutOfRangeException idorEx)
            {
                MessageBox.Show("Error caught by child himself.");
                return 0m;    
            }
        }
    }
}
