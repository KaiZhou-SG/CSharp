﻿namespace frmDispose
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.childFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseChildFrom = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // childFormToolStripMenuItem
            // 
            this.childFormToolStripMenuItem.Name = "childFormToolStripMenuItem";
            this.childFormToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.childFormToolStripMenuItem.Text = "ChildForm";
            this.childFormToolStripMenuItem.Click += new System.EventHandler(this.childFormToolStripMenuItem_Click);
            // 
            // btnCloseChildFrom
            // 
            this.btnCloseChildFrom.AutoSize = true;
            this.btnCloseChildFrom.Location = new System.Drawing.Point(154, 257);
            this.btnCloseChildFrom.Name = "btnCloseChildFrom";
            this.btnCloseChildFrom.Size = new System.Drawing.Size(116, 39);
            this.btnCloseChildFrom.TabIndex = 1;
            this.btnCloseChildFrom.Text = "CloseChildForm";
            this.btnCloseChildFrom.UseVisualStyleBackColor = true;
            this.btnCloseChildFrom.Click += new System.EventHandler(this.btnCloseChildFrom_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 330);
            this.Controls.Add(this.btnCloseChildFrom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem childFormToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseChildFrom;
    }
}

