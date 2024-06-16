using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OOPlab25
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(452, 513);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
        private void InitializeCustomComponents()
        {
            // Labels
            Label lblChildName = new Label { Text = "Driver Name", Location = new System.Drawing.Point(10, 10) };
            Label lblGuardianName = new Label { Text = "Car Model", Location = new System.Drawing.Point(10, 40) };
            Label lblGuardianPhone = new Label { Text = "Driver Phone", Location = new System.Drawing.Point(10, 70) };
            Label lblBirthDate = new Label { Text = "Join Date", Location = new System.Drawing.Point(10, 100) };

            // TextBoxes
            txtChildName = new TextBox { Location = new System.Drawing.Point(120, 10) };
            txtGuardianName = new TextBox { Location = new System.Drawing.Point(120, 40) };
            txtGuardianPhone = new TextBox { Location = new System.Drawing.Point(120, 70) };

            // DateTimePicker
            dtpBirthDate = new DateTimePicker { Location = new System.Drawing.Point(120, 100) };

            // Buttons
            btnAdd = new Button { Text = "Add", Location = new System.Drawing.Point(10, 140) };
            btnAdd.Click += new EventHandler(btnAdd_Click);

            // Age Report
            Label lblAge = new Label { Text = "Worktime", Location = new System.Drawing.Point(10, 180) };
            txtAge = new TextBox { Location = new System.Drawing.Point(120, 180) };
            btnReportByAge = new Button { Text = "Report by Worktime", Location = new System.Drawing.Point(250, 180) };
            btnReportByAge.Click += new EventHandler(btnReportByAge_Click);

            // Guardian Report
            Label lblReportGuardianName = new Label { Text = "Car Model", Location = new System.Drawing.Point(10, 220) };
            txtReportGuardianName = new TextBox { Location = new System.Drawing.Point(120, 220) };
            btnReportByGuardian = new Button { Text = "Report by Car", Location = new System.Drawing.Point(250, 220) };
            btnReportByGuardian.Click += new EventHandler(btnReportByGuardian_Click);

            // Search
            Label lblSearch = new Label { Text = "Search Driver", Location = new System.Drawing.Point(10, 260) };
            txtSearch = new TextBox { Location = new System.Drawing.Point(120, 260) };
            btnSearch = new Button { Text = "Search", Location = new System.Drawing.Point(250, 260) };
            btnSearch.Click += new EventHandler(btnSearch_Click);

            // ListBox for results
            listBoxResults = new ListBox { Location = new System.Drawing.Point(10, 300), Size = new System.Drawing.Size(350, 150) };

            // Add controls to form
            this.Controls.Add(lblChildName);
            this.Controls.Add(txtChildName);
            this.Controls.Add(lblGuardianName);
            this.Controls.Add(txtGuardianName);
            this.Controls.Add(lblGuardianPhone);
            this.Controls.Add(txtGuardianPhone);
            this.Controls.Add(lblBirthDate);
            this.Controls.Add(dtpBirthDate);
            this.Controls.Add(btnAdd);
            this.Controls.Add(lblAge);
            this.Controls.Add(txtAge);
            this.Controls.Add(btnReportByAge);
            this.Controls.Add(lblReportGuardianName);
            this.Controls.Add(txtReportGuardianName);
            this.Controls.Add(btnReportByGuardian);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
            this.Controls.Add(listBoxResults);
        }
        #endregion

        private OleDbConnection connection;
        private TextBox txtChildName;
        private TextBox txtGuardianName;
        private TextBox txtGuardianPhone;
        private DateTimePicker dtpBirthDate;
        private Button btnAdd;
        private TextBox txtAge;
        private Button btnReportByAge;
        private TextBox txtReportGuardianName;
        private Button btnReportByGuardian;
        private TextBox txtSearch;
        private Button btnSearch;
        private ListBox listBoxResults;
    }
}

