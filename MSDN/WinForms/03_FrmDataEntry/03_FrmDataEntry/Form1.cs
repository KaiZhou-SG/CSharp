using System.Windows.Forms;

namespace _03_FrmDataEntry
{
    /// <summary>
    /// 2014-09-12 Zhou Kai adds summary:
    /// 1 The application makes use of the TableLayoutPanel control to manage
    ///    the layout of the controls
    /// 2 The labels and text-boxes use the Anchor property to make themselves
    ///    resize correctly according to the form(the resize of the form will not)
    /// 3 There are two MaskTextBox used, you can set the SetMask property of
    ///    of MaskTextBox to different format, in this application, they're set to 
    ///    telephone number.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
