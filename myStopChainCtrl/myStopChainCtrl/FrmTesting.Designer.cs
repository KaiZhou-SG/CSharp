namespace myStopChainCtrl
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
            this.myStopChainCtrl1 = new myStopChainCtrl();
            this.SuspendLayout();
            // 
            // myStopChainCtrl1
            // 
            this.myStopChainCtrl1.Location = new System.Drawing.Point(23, 25);
            this.myStopChainCtrl1.Name = "myStopChainCtrl1";
            this.myStopChainCtrl1.SelectedStops = null;
            this.myStopChainCtrl1.Size = new System.Drawing.Size(843, 254);
            this.myStopChainCtrl1.TabIndex = 0;
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 491);
            this.Controls.Add(this.myStopChainCtrl1);
            this.Name = "FrmTesting";
            this.Text = "FrmTesting";
            this.ResumeLayout(false);

        }

        #endregion

        private myStopChainCtrl myStopChainCtrl1;
    }
}