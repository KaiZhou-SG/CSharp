namespace userControl01
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
            this.lblInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNtxt1 = new userControl00.btnNtxt();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(85, 79);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(79, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "WaitForConfirm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // btnNtxt1
            // 
            this.btnNtxt1.input = null;
            this.btnNtxt1.Location = new System.Drawing.Point(24, 24);
            this.btnNtxt1.Name = "btnNtxt1";
            this.btnNtxt1.Size = new System.Drawing.Size(200, 28);
            this.btnNtxt1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnNtxt1);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControl00.btnNtxt btnNtxt1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label1;
    }
}

