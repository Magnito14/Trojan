namespace Trojan
{
    partial class Sounds
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
            this.SoundTMR = new System.Windows.Forms.Timer(this.components);
            this.NextPayloadTMR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SoundTMR
            // 
            this.SoundTMR.Enabled = true;
            this.SoundTMR.Interval = 300;
            this.SoundTMR.Tick += new System.EventHandler(this.SoundTMR_Tick);
            // 
            // NextPayloadTMR
            // 
            this.NextPayloadTMR.Enabled = true;
            this.NextPayloadTMR.Interval = 30000;
            this.NextPayloadTMR.Tick += new System.EventHandler(this.NextPayloadTMR_Tick);
            // 
            // Sounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(10, 10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sounds";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sounds";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sounds_FormClosing);
            this.Load += new System.EventHandler(this.Sounds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SoundTMR;
        private System.Windows.Forms.Timer NextPayloadTMR;
    }
}