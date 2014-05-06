using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEvent
{
    // 2014-01-08 Zhou Kai adds comments:

    public partial class Form1 : Form
    {
        private DelClose delClose;

        private Point firstPoint;
        private Boolean haveFirstPoint;

        public Form1()
        {
            InitializeComponent();
            // delClose = CloseForm;
            PutButton();
        }

        private void PutButton()
        {
            // creates a button
            Button btnClose = new Button();
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Text = "Click to Close the Form";
            btnClose.Height = this.Height / 3;

            // adds button to the form
            this.Controls.Add(btnClose);
            
            // adds event handler to the button created
            GiveEventHandlerToButton(btnClose);
        }

        private void GiveEventHandlerToButton(Button btn)
        {
            // btn.Click += btn_Click;
            btn.Click += CloseForm;

            // the way below also works, it's a standard way
            // btn.Click += new EventHandler(CloseForm); // also Correct
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // use the Parent property to represent the form
            Form frm = btn.Parent as Form;
            frm.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        public void EnableDrawing()
        {
            this.MouseDown += new MouseEventHandler(Form1_MouseDownDrawing);
        }

        void Form1_MouseDownDrawing(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (haveFirstPoint)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Black, firstPoint, e.Location);
                haveFirstPoint = false;
            }
            else
            {
                firstPoint = e.Location;
                haveFirstPoint = true;
            }
        }

    }

    public delegate void DelClose(object sender, EventArgs e);

}
