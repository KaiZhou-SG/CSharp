namespace frmDragDrop03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsvTruck = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxTruckCondition = new System.Windows.Forms.TextBox();
            this.tbxDriverLicense = new System.Windows.Forms.TextBox();
            this.tbxDriverName = new System.Windows.Forms.TextBox();
            this.tbxTrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.delTruck = new System.Windows.Forms.Button();
            this.btnAddTruck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 314);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvTruck);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(565, 314);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // lsvTruck
            // 
            this.lsvTruck.AllowDrop = true;
            this.lsvTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTruck.Location = new System.Drawing.Point(0, 0);
            this.lsvTruck.Name = "lsvTruck";
            this.lsvTruck.Size = new System.Drawing.Size(188, 314);
            this.lsvTruck.TabIndex = 0;
            this.lsvTruck.UseCompatibleStateImageBehavior = false;
            this.lsvTruck.View = System.Windows.Forms.View.List;
            this.lsvTruck.DragOver += new System.Windows.Forms.DragEventHandler(this.lsvTruck_DragOver);
            this.lsvTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsvTruck_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxTruckCondition);
            this.groupBox1.Controls.Add(this.tbxDriverLicense);
            this.groupBox1.Controls.Add(this.tbxDriverName);
            this.groupBox1.Controls.Add(this.tbxTrNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truck Info:";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
            this.groupBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragOver);
            // 
            // tbxTruckCondition
            // 
            this.tbxTruckCondition.Location = new System.Drawing.Point(192, 175);
            this.tbxTruckCondition.Name = "tbxTruckCondition";
            this.tbxTruckCondition.Size = new System.Drawing.Size(100, 20);
            this.tbxTruckCondition.TabIndex = 3;
            // 
            // tbxDriverLicense
            // 
            this.tbxDriverLicense.Location = new System.Drawing.Point(192, 132);
            this.tbxDriverLicense.Name = "tbxDriverLicense";
            this.tbxDriverLicense.Size = new System.Drawing.Size(100, 20);
            this.tbxDriverLicense.TabIndex = 2;
            // 
            // tbxDriverName
            // 
            this.tbxDriverName.Location = new System.Drawing.Point(192, 89);
            this.tbxDriverName.Name = "tbxDriverName";
            this.tbxDriverName.Size = new System.Drawing.Size(100, 20);
            this.tbxDriverName.TabIndex = 1;
            // 
            // tbxTrNo
            // 
            this.tbxTrNo.Location = new System.Drawing.Point(192, 46);
            this.tbxTrNo.Name = "tbxTrNo";
            this.tbxTrNo.Size = new System.Drawing.Size(100, 20);
            this.tbxTrNo.TabIndex = 0;
            this.tbxTrNo.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxTrNo_DragDrop);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Truck Condition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver Liscense:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Driver Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck Number:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.delTruck);
            this.panel2.Controls.Add(this.btnAddTruck);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 119);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(384, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // delTruck
            // 
            this.delTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delTruck.Location = new System.Drawing.Point(228, 59);
            this.delTruck.Name = "delTruck";
            this.delTruck.Size = new System.Drawing.Size(75, 23);
            this.delTruck.TabIndex = 1;
            this.delTruck.Text = "Delete_Truck";
            this.delTruck.UseVisualStyleBackColor = true;
            // 
            // btnAddTruck
            // 
            this.btnAddTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTruck.Location = new System.Drawing.Point(96, 59);
            this.btnAddTruck.Name = "btnAddTruck";
            this.btnAddTruck.Size = new System.Drawing.Size(75, 23);
            this.btnAddTruck.TabIndex = 0;
            this.btnAddTruck.Text = "Add_Truck";
            this.btnAddTruck.UseVisualStyleBackColor = true;
            this.btnAddTruck.Click += new System.EventHandler(this.btnAddTruck_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddTruck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(565, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lsvTruck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button delTruck;
        private System.Windows.Forms.Button btnAddTruck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxTruckCondition;
        private System.Windows.Forms.TextBox tbxDriverLicense;
        private System.Windows.Forms.TextBox tbxDriverName;
        private System.Windows.Forms.TextBox tbxTrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

