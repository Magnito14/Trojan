namespace Trojan
{
    partial class Payload
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
            this.PayloadTMR = new System.Windows.Forms.Timer(this.components);
            this.NextPayloadTMR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PayloadTMR
            // 
            this.PayloadTMR.Enabled = true;
            this.PayloadTMR.Interval = 15000;
            this.PayloadTMR.Tick += new System.EventHandler(this.PayloadTMR_Tick);
            // 
            // NextPayloadTMR
            // 
            this.NextPayloadTMR.Enabled = true;
            this.NextPayloadTMR.Interval = 20000;
            this.NextPayloadTMR.Tick += new System.EventHandler(this.NextPayloadTMR_Tick);
            // 
            // Payload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(10, 10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payload";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payload_FormClosing);
            this.Load += new System.EventHandler(this.Payload_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PayloadTMR;
        private System.Windows.Forms.Timer NextPayloadTMR;
    }
}