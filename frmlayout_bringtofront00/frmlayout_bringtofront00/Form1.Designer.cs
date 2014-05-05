namespace frmLayout_BringToFront00
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnSwitchTo1 = new System.Windows.Forms.Button();
            this.btnSwitchTo2 = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lbl1);
            this.grp1.Location = new System.Drawing.Point(0, 0);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(203, 164);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "grp1";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.lbl2);
            this.grp2.Controls.Add(this.grp1);
            this.grp2.Location = new System.Drawing.Point(202, 46);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(200, 164);
            this.grp2.TabIndex = 1;
            this.grp2.TabStop = false;
            this.grp2.Text = "grp2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(61, 74);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "I\'m layer 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(74, 75);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(54, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "I\'m layer 2";
            // 
            // btnSwitchTo1
            // 
            this.btnSwitchTo1.Location = new System.Drawing.Point(202, 292);
            this.btnSwitchTo1.Name = "btnSwitchTo1";
            this.btnSwitchTo1.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchTo1.TabIndex = 2;
            this.btnSwitchTo1.Text = "&SwitchTo1";
            this.btnSwitchTo1.UseVisualStyleBackColor = true;
            this.btnSwitchTo1.Click += new System.EventHandler(this.btnSwitchTo1_Click);
            // 
            // btnSwitchTo2
            // 
            this.btnSwitchTo2.Location = new System.Drawing.Point(324, 292);
            this.btnSwitchTo2.Name = "btnSwitchTo2";
            this.btnSwitchTo2.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchTo2.TabIndex = 3;
            this.btnSwitchTo2.Text = "&SwitchTo2";
            this.btnSwitchTo2.UseVisualStyleBackColor = true;
            this.btnSwitchTo2.Click += new System.EventHandler(this.btnSwitchTo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 377);
            this.Controls.Add(this.btnSwitchTo2);
            this.Controls.Add(this.btnSwitchTo1);
            this.Controls.Add(this.grp2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnSwitchTo1;
        private System.Windows.Forms.Button btnSwitchTo2;
    }
}

