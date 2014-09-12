using System;
using System.Windows.Forms;

namespace _01_FrmCalculator00
{
    /// <summary>
    /// 2014-09-12 Zhou Kai adds summary of this application:
    /// 1 This project is a Windows Forms Control Library, it will be compiled
    ///   as a custom control(a .dll), and can be later on used in other
    ///   WinForm applications, by adding the .dll as reference, and then go
    ///   to the toolbox, right click the toolbox, choose "Choose Items", 
    ///    and add the .dll. This custom control will then be available to be
    ///    put on the WinForm.
    /// 2 This project used SplitContainer and TableLayoutPanel to manage the
    ///    layout of the controls.
    /// 3 The url of this project:
    ///http://msdn.microsoft.com/en-us/library/vstudio/9ew6tzdt%28v=vs.110%29.aspx
    ///    
    /// </summary>
    public partial class DemoCalculator : UserControl
    {
        public DemoCalculator()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5 is clicked.");
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7 is clicked.");
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8 is clicked.");
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9 is clicked.");
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/ is clicked.");
        }

        private void multiplicationBtun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* is clicked.");
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("= is clicked.");
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ is clicked.");
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- is clicked.");
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 is clicked.");
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(". is clicked.");
        }

        private void changeSignBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+/- is clicked.");
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 is clicked.");
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 is clicked.");
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 is clicked.");
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 is clicked.");
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5 is clicked.");
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6 is clicked.");
        }
    }
}
