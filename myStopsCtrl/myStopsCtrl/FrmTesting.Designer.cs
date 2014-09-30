namespace myStopsCtrl
{
    partial class FrmTesting
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
            this.myStopsCtrl1 = new myStopsCtrl();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myStopsCtrl1
            // 
            this.myStopsCtrl1.BdsStops = null;
            this.myStopsCtrl1.Location = new System.Drawing.Point(0, -1);
            this.myStopsCtrl1.Name = "myStopsCtrl1";
            this.myStopsCtrl1.Size = new System.Drawing.Size(875, 401);
            this.myStopsCtrl1.TabIndex = 0;
            this.myStopsCtrl1.Load += new System.EventHandler(this.myStopsCtrl1_Load);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(151, 443);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 1;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 481);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.myStopsCtrl1);
            this.Name = "FrmTesting";
            this.Text = "FrmTesting";
            this.Load += new System.EventHandler(this.FrmTesting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private myStopsCtrl myStopsCtrl1;
        private System.Windows.Forms.Button btnInitialize;
    }
}