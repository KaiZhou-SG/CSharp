﻿namespace frmRef01
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
            this.btnAddOneToStrTmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddOneToStrTmp
            // 
            this.btnAddOneToStrTmp.Location = new System.Drawing.Point(138, 242);
            this.btnAddOneToStrTmp.Name = "btnAddOneToStrTmp";
            this.btnAddOneToStrTmp.Size = new System.Drawing.Size(138, 56);
            this.btnAddOneToStrTmp.TabIndex = 0;
            this.btnAddOneToStrTmp.Text = "btnAddOne";
            this.btnAddOneToStrTmp.UseVisualStyleBackColor = true;
            this.btnAddOneToStrTmp.Click += new System.EventHandler(this.btnAddOneToStrTmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 343);
            this.Controls.Add(this.btnAddOneToStrTmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOneToStrTmp;
    }
}

