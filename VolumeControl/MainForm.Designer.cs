namespace VolumeControl
{
    partial class MainForm
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
            this.btnMuteToggle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMuteWithDelay = new System.Windows.Forms.Button();
            this.txtDelaySeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMuteToggle
            // 
            this.btnMuteToggle.Location = new System.Drawing.Point(12, 14);
            this.btnMuteToggle.Name = "btnMuteToggle";
            this.btnMuteToggle.Size = new System.Drawing.Size(121, 23);
            this.btnMuteToggle.TabIndex = 0;
            this.btnMuteToggle.Text = "Mute Toggle";
            this.btnMuteToggle.UseVisualStyleBackColor = true;
            this.btnMuteToggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMuteWithDelay
            // 
            this.btnMuteWithDelay.Location = new System.Drawing.Point(12, 58);
            this.btnMuteWithDelay.Name = "btnMuteWithDelay";
            this.btnMuteWithDelay.Size = new System.Drawing.Size(121, 23);
            this.btnMuteWithDelay.TabIndex = 1;
            this.btnMuteWithDelay.Text = "Mute with delay";
            this.btnMuteWithDelay.UseVisualStyleBackColor = true;
            this.btnMuteWithDelay.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDelaySeconds
            // 
            this.txtDelaySeconds.Location = new System.Drawing.Point(139, 60);
            this.txtDelaySeconds.Name = "txtDelaySeconds";
            this.txtDelaySeconds.Size = new System.Drawing.Size(54, 20);
            this.txtDelaySeconds.TabIndex = 2;
            this.txtDelaySeconds.Text = "58";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "seconds";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelaySeconds);
            this.Controls.Add(this.btnMuteWithDelay);
            this.Controls.Add(this.btnMuteToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Muter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMuteToggle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMuteWithDelay;
        private System.Windows.Forms.TextBox txtDelaySeconds;
        private System.Windows.Forms.Label label1;
    }
}

