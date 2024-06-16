namespace UdpChat
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.localPortLabel = new System.Windows.Forms.Label();
            this.remotePortLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.localPortTextBox = new System.Windows.Forms.TextBox();
            this.remotePortTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localPortLabel
            // 
            this.localPortLabel.AutoSize = true;
            this.localPortLabel.Location = new System.Drawing.Point(12, 15);
            this.localPortLabel.Name = "localPortLabel";
            this.localPortLabel.Size = new System.Drawing.Size(58, 13);
            this.localPortLabel.TabIndex = 0;
            this.localPortLabel.Text = "Local Port:";
            // 
            // remotePortLabel
            // 
            this.remotePortLabel.AutoSize = true;
            this.remotePortLabel.Location = new System.Drawing.Point(12, 41);
            this.remotePortLabel.Name = "remotePortLabel";
            this.remotePortLabel.Size = new System.Drawing.Size(70, 13);
            this.remotePortLabel.TabIndex = 1;
            this.remotePortLabel.Text = "Remote Port:";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(12, 67);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(32, 13);
            this.hostLabel.TabIndex = 2;
            this.hostLabel.Text = "Host:";
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(12, 93);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(31, 13);
            this.fontLabel.TabIndex = 3;
            this.fontLabel.Text = "Font:";
            // 
            // localPortTextBox
            // 
            this.localPortTextBox.Location = new System.Drawing.Point(88, 12);
            this.localPortTextBox.Name = "localPortTextBox";
            this.localPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.localPortTextBox.TabIndex = 4;
            // 
            // remotePortTextBox
            // 
            this.remotePortTextBox.Location = new System.Drawing.Point(88, 38);
            this.remotePortTextBox.Name = "remotePortTextBox";
            this.remotePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.remotePortTextBox.TabIndex = 5;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(88, 64);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostTextBox.TabIndex = 6;
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(88, 90);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(100, 20);
            this.fontTextBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(113, 125);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 23);
            this.fontButton.TabIndex = 9;
            this.fontButton.Text = "Select Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 160);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fontTextBox);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.remotePortTextBox);
            this.Controls.Add(this.localPortTextBox);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.remotePortLabel);
            this.Controls.Add(this.localPortLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label localPortLabel;
        private System.Windows.Forms.Label remotePortLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.TextBox localPortTextBox;
        private System.Windows.Forms.TextBox remotePortTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button fontButton;
    }
}