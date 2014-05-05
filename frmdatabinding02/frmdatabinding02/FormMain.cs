using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDatabinding02
{
    /// <summary>
    /// This project is a practice for learning databinding and events
    ///     1. definition of data binding:
    ///       a. The connection between a control property and a data source property is called a binding.
    ///       b. Any property of any control can be bound to any property of any data source, 
    ///          including any properties you define for your own controls.
    ///       c. A single control could have many bindings associated with it
    ///          (In theory, each property associates with one data source property)
    ///       d. Any single control property cannot be bound to more than one data source.
    ///       e. A single data source property can be bound to any number of control properties.
    ///     2. Synchronizations between the data source property and the control property
    ///       a. when a control property changed, the associated data source property will always changes automatically
    ///       b. when a data source property changes, it looks for an associated event whose name will be the property's namae with "Changed" appended. And if 
    ///         such event exists, it will register an event handler, and every time the event is raised, it will refresh any controls that are bound to this data source 
    ///         property.
    ///       c. 
    /// </summary>
    public partial class FormMain : Form
    {
        #region "Private member variables"
        private string userName;
        private string passWord;
        private FrmChild1 frmChild1;
        #endregion

        #region "Public member variables"
        // when the datasource property changed, the event
        // raised and notifies the control property to change 
        public event EventHandler UserNameChanged;
        public event EventHandler PasswordChanged;
        #endregion

        #region "Constructors"
        public FormMain()
        {
            InitializeComponent();

            userName = String.Empty;
            passWord = String.Empty;
            frmChild1 = new FrmChild1(userName, passWord);
            frmChild1.Show();

            // databinding
            // bind Text control property to UserName and Password datasource property.
            // so when the control property changes, the datasource property will change
            tbxUsername.DataBindings.Add(new Binding("Text", this, "UserName"));
            tbxPassword.DataBindings.Add(new Binding("Text", this, "Password"));
            // end of databinding
        }
        #endregion

        #region "Event handlers"
        private void btnOK_clicked(object sender, EventArgs e)
        {
            string tmp = "The username is: {0} and the password is: {1}";
            tmp = String.Format(tmp, userName, passWord);
            frmChild1.UpdateInfo(userName, passWord);

            MessageBox.Show(tmp);
            return;
        }

        protected virtual void OnUserNameChanged()
        {
            if (UserNameChanged != null)
            {
                // this is the real event handler
                UserNameChanged(this, EventArgs.Empty);
            }
        }

        protected virtual void OnPasswordChanged()
        {
            if (PasswordChanged != null)
            {
                // this is the real event handler
                PasswordChanged(this, EventArgs.Empty);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region "Public properties(these two properties are used as datasource properties)"
        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                OnUserNameChanged(); // trigger event 
            }
        }

        public string Password
        {
            get { return passWord; }
            set 
            { 
                passWord = value;
                OnPasswordChanged(); // trigger event
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = textBox1.Text; // set datasource property, raise UserNameChanged event
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text; // set datasource property, raise PasswordChanged event
        }
        #endregion

    }
}
