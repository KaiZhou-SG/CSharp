﻿namespace frmRef03
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
            this.btnMakeAChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeAChange
            // 
            this.btnMakeAChange.Location = new System.Drawing.Point(82, 189);
            this.btnMakeAChange.Name = "btnMakeAChange";
            this.btnMakeAChange.Size = new System.Drawing.Size(100, 40);
            this.btnMakeAChange.TabIndex = 0;
            this.btnMakeAChange.Text = "MakeAChange";
            this.btnMakeAChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMakeAChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeAChange;
    }
}

