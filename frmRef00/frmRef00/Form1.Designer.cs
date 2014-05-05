namespace frmRef00
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStrList = new System.Windows.Forms.ListBox();
            this.bdsStrList = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddOneToStrCurrent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStrList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddOneToStrCurrent);
            this.panel1.Controls.Add(this.lbStrList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 291);
            this.panel1.TabIndex = 0;
            // 
            // lbStrList
            // 
            this.lbStrList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStrList.FormattingEnabled = true;
            this.lbStrList.Location = new System.Drawing.Point(0, 0);
            this.lbStrList.Name = "lbStrList";
            this.lbStrList.Size = new System.Drawing.Size(496, 225);
            this.lbStrList.TabIndex = 0;
            // 
            // btnAddOneToStrCurrent
            // 
            this.btnAddOneToStrCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOneToStrCurrent.Location = new System.Drawing.Point(0, 225);
            this.btnAddOneToStrCurrent.Name = "btnAddOneToStrCurrent";
            this.btnAddOneToStrCurrent.Size = new System.Drawing.Size(496, 66);
            this.btnAddOneToStrCurrent.TabIndex = 1;
            this.btnAddOneToStrCurrent.Text = "AddOne";
            this.btnAddOneToStrCurrent.UseVisualStyleBackColor = true;
            this.btnAddOneToStrCurrent.Click += new System.EventHandler(this.btnAddOneToStrCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 291);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsStrList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbStrList;
        private System.Windows.Forms.BindingSource bdsStrList;
        private System.Windows.Forms.Button btnAddOneToStrCurrent;
    }
}

