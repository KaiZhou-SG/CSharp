using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AbstractsANDInterfaces
{
	/// <summary>
	/// Summary description for user interface.
	/// </summary>
	public class frmAbsInt : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button InterfaceExample;
		private System.Windows.Forms.Button cmdAbstractExample;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmAbsInt()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.InterfaceExample = new System.Windows.Forms.Button();
			this.cmdAbstractExample = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InterfaceExample
			// 
			this.InterfaceExample.Location = new System.Drawing.Point(72, 40);
			this.InterfaceExample.Name = "InterfaceExample";
			this.InterfaceExample.Size = new System.Drawing.Size(136, 24);
			this.InterfaceExample.TabIndex = 0;
			this.InterfaceExample.Text = "Interface Example";
			this.InterfaceExample.Click += new System.EventHandler(this.InterfaceExample_Click);
			// 
			// cmdAbstractExample
			// 
			this.cmdAbstractExample.Location = new System.Drawing.Point(72, 80);
			this.cmdAbstractExample.Name = "cmdAbstractExample";
			this.cmdAbstractExample.Size = new System.Drawing.Size(136, 24);
			this.cmdAbstractExample.TabIndex = 1;
			this.cmdAbstractExample.Text = "Abstract Example";
			this.cmdAbstractExample.Click += new System.EventHandler(this.cmdAbstractExample_Click);
			// 
			// frmAbsInt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 265);
			this.Controls.Add(this.cmdAbstractExample);
			this.Controls.Add(this.InterfaceExample);
			this.Name = "frmAbsInt";
			this.Text = "Abstracts n Interfaces";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmAbsInt());
		}
		
		//In this sub i create an arraylist.
		//then create a fulltime and assign it to IEmpoloyee
		//then set the properties ...
		//and then adding the empolyee in the arraylist
		//then repeating the same process for the contractor employee
		//finally looping through the arraylist to call the calculate wage
		//method of the objects without knowing the type of the objects!
		private void InterfaceExample_Click(object sender, System.EventArgs e)
		{
			try
			{

				IEmployee emp;

				Emp_fulltime2 emp1 = new Emp_fulltime2();
				//has to be casted because of the interface!
				emp = (IEmployee) emp1;
				emp.ID = "2234";
				emp.FirstName= "Rahman" ;
				emp.LastName = "Mahmoodi" ;
                
				//call add method od the object
				MessageBox.Show(emp.Add().ToString());
				
				//call the CalculateWage method
				MessageBox.Show(emp.CalculateWage().ToString());
                //call 
                MessageBox.Show("Interface methods can't have implementation," +
                    " so I'm using my own calculate implementation.");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			}

		private void cmdAbstractExample_Click(object sender, System.EventArgs e)
		{

			Employee emp;
			//no casting is requird!
		    emp = new Emp_Fulltime();
			

			emp.ID = "2234";
			emp.FirstName= "Rahman" ;
			emp.LastName = "Mahmoodi" ;
			MessageBox.Show(emp.Add().ToString());

			//call the CalculateWage method
			MessageBox.Show(emp.CalculateWage().ToString());
            MessageBox.Show("Although Abstract class has implement the calculate method for me, " +
                "but I'm still using my own calculate method decided at run time.");

		}


	}
}
