namespace textChange00
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
            this.comBoBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comBoBox1
            // 
            this.comBoBox1.FormattingEnabled = true;
            this.comBoBox1.Location = new System.Drawing.Point(265, 48);
            this.comBoBox1.Name = "comBoBox1";
            this.comBoBox1.Size = new System.Drawing.Size(121, 21);
            this.comBoBox1.TabIndex = 0;
            this.comBoBox1.SelectedIndexChanged += new System.EventHandler(this.comBoBox1_SelectedIndexChanged);
            this.comBoBox1.TextChanged += new System.EventHandler(this.comBoBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.comBoBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoBox1;
    }
}

