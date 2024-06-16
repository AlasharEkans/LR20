namespace lab23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtB = new TextBox();
            txtX0 = new TextBox();
            txtY0 = new TextBox();
            btnDraw = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(0, 100);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(0, 150);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // txtX0
            // 
            txtX0.Location = new Point(0, 200);
            txtX0.Name = "txtX0";
            txtX0.Size = new Size(100, 23);
            txtX0.TabIndex = 2;
            // 
            // txtY0
            // 
            txtY0.Location = new Point(0, 250);
            txtY0.Name = "txtY0";
            txtY0.Size = new Size(100, 23);
            txtY0.TabIndex = 3;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(15, 300);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 4;
            btnDraw.Text = "Draw";
            btnDraw.Click += BtnDraw_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(200, 100);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(300, 300);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.Paint += PictureBox_Paint;
            // 
            // Form1
            // 
            ClientSize = new Size(761, 564);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtX0);
            Controls.Add(txtY0);
            Controls.Add(btnDraw);
            Controls.Add(pictureBox);
            Name = "ElipseDraw";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
