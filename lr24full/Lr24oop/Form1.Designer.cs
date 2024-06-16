
namespace Lr24oop
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

    
        /// <param name="disposing">вірно, якщо керовані ресурси повинні бути видалені; інакше - невірно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, який створено конструктором Windows Form

      
        private void InitializeComponent()
        {
            this.buttonLUCIFER = new System.Windows.Forms.Button();
            this.buttonNHash = new System.Windows.Forms.Button();
            this.buttonRSA = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.textBoxLUCIFER = new System.Windows.Forms.TextBox();
            this.textBoxNHash = new System.Windows.Forms.TextBox();
            this.textBoxRSA = new System.Windows.Forms.TextBox();
            this.labelLUCIFER = new System.Windows.Forms.Label();
            this.labelNHash = new System.Windows.Forms.Label();
            this.labelRSA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLUCIFER
            // 
            this.buttonLUCIFER.Location = new System.Drawing.Point(30, 30);
            this.buttonLUCIFER.Name = "buttonLUCIFER";
            this.buttonLUCIFER.Size = new System.Drawing.Size(150, 30);
            this.buttonLUCIFER.TabIndex = 0;
            this.buttonLUCIFER.Text = "Start LUCIFER";
            this.buttonLUCIFER.UseVisualStyleBackColor = true;
            this.buttonLUCIFER.Click += new System.EventHandler(this.buttonLUCIFER_Click);
            // 
            // buttonNHash
            // 
            this.buttonNHash.Location = new System.Drawing.Point(30, 80);
            this.buttonNHash.Name = "buttonNHash";
            this.buttonNHash.Size = new System.Drawing.Size(150, 30);
            this.buttonNHash.TabIndex = 1;
            this.buttonNHash.Text = "Start N-Hash";
            this.buttonNHash.UseVisualStyleBackColor = true;
            this.buttonNHash.Click += new System.EventHandler(this.buttonNHash_Click);
            // 
            // buttonRSA
            // 
            this.buttonRSA.Location = new System.Drawing.Point(30, 130);
            this.buttonRSA.Name = "buttonRSA";
            this.buttonRSA.Size = new System.Drawing.Size(150, 30);
            this.buttonRSA.TabIndex = 2;
            this.buttonRSA.Text = "Start RSA";
            this.buttonRSA.UseVisualStyleBackColor = true;
            this.buttonRSA.Click += new System.EventHandler(this.buttonRSA_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(30, 180);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(150, 30);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "Start All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.Location = new System.Drawing.Point(30, 230);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(150, 30);
            this.buttonStopAll.TabIndex = 4;
            this.buttonStopAll.Text = "Stop All";
            this.buttonStopAll.UseVisualStyleBackColor = true;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonStopAll_Click);
            // 
            // textBoxLUCIFER
            // 
            this.textBoxLUCIFER.Location = new System.Drawing.Point(200, 35);
            this.textBoxLUCIFER.Name = "textBoxLUCIFER";
            this.textBoxLUCIFER.Size = new System.Drawing.Size(300, 22);
            this.textBoxLUCIFER.TabIndex = 5;
            // 
            // textBoxNHash
            // 
            this.textBoxNHash.Location = new System.Drawing.Point(200, 85);
            this.textBoxNHash.Name = "textBoxNHash";
            this.textBoxNHash.Size = new System.Drawing.Size(300, 22);
            this.textBoxNHash.TabIndex = 6;
            // 
            // textBoxRSA
            // 
            this.textBoxRSA.Location = new System.Drawing.Point(200, 135);
            this.textBoxRSA.Name = "textBoxRSA";
            this.textBoxRSA.Size = new System.Drawing.Size(300, 22);
            this.textBoxRSA.TabIndex = 7;
            // 
            // labelLUCIFER
            // 
            this.labelLUCIFER.AutoSize = true;
            this.labelLUCIFER.Location = new System.Drawing.Point(200, 15);
            this.labelLUCIFER.Name = "labelLUCIFER";
            this.labelLUCIFER.Size = new System.Drawing.Size(56, 16);
            this.labelLUCIFER.TabIndex = 8;
            this.labelLUCIFER.Text = "LUCIFER";
            // 
            // labelNHash
            // 
            this.labelNHash.AutoSize = true;
            this.labelNHash.Location = new System.Drawing.Point(200, 65);
            this.labelNHash.Name = "labelNHash";
            this.labelNHash.Size = new System.Drawing.Size(48, 16);
            this.labelNHash.TabIndex = 9;
            this.labelNHash.Text = "N-Hash";
            // 
            // labelRSA
            // 
            this.labelRSA.AutoSize = true;
            this.labelRSA.Location = new System.Drawing.Point(200, 115);
            this.labelRSA.Name = "labelRSA";
            this.labelRSA.Size = new System.Drawing.Size(36, 16);
            this.labelRSA.TabIndex = 10;
            this.labelRSA.Text = "RSA";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.labelRSA);
            this.Controls.Add(this.labelNHash);
            this.Controls.Add(this.labelLUCIFER);
            this.Controls.Add(this.textBoxRSA);
            this.Controls.Add(this.textBoxNHash);
            this.Controls.Add(this.textBoxLUCIFER);
            this.Controls.Add(this.buttonStopAll);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRSA);
            this.Controls.Add(this.buttonNHash);
            this.Controls.Add(this.buttonLUCIFER);
            this.Name = "Form1";
            this.Text = "Encryption App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonLUCIFER;
        private System.Windows.Forms.Button buttonNHash;
        private System.Windows.Forms.Button buttonRSA;
        private System.Windows.Forms.TextBox textBoxLUCIFER;
        private System.Windows.Forms.TextBox textBoxNHash;
        private System.Windows.Forms.TextBox textBoxRSA;
        private System.Windows.Forms.Label labelLUCIFER;
        private System.Windows.Forms.Label labelNHash;
        private System.Windows.Forms.Label labelRSA;
        private System.Windows.Forms.Button buttonStopAll;
    }
}

