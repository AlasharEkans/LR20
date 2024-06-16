using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OOPlab25.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Diagnostics.Tracing;
using System.Drawing.Printing;

namespace OOPlab25
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Home-PC\source\repos\OOPlab25\transport.accdb;";
            connection = new OleDbConnection(connectionString);
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtChildName.Text))
            {
                MessageBox.Show("Please enter driver name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGuardianName.Text))
            {
                MessageBox.Show("Please enter car name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGuardianPhone.Text))
            {
                MessageBox.Show("Please enter driver phone.");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; 
            }
            string Driver = txtChildName.Text;
            string Car = txtGuardianName.Text;
            string DriverPhone = txtGuardianPhone.Text;
            DateTime JoinDate = dtpBirthDate.Value;

            string query = "INSERT INTO garden (Driver, Car, DriverPhone, JoinDate) VALUES (?, ?, ?, ?)";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Driver", Driver);
                command.Parameters.AddWithValue("@Car", Car);
                command.Parameters.AddWithValue("@DriverPhone", DriverPhone);
                command.Parameters.AddWithValue("@JoinDate", JoinDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void btnReportByAge_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            string query = "SELECT Driver, Car, DriverPhone, JoinDate FROM garden WHERE YEAR(JoinDate) = ?";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Year", DateTime.Now.Year - int.Parse(txtAge.Text));
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxResults.Items.Add($"{reader["Driver"]}, {reader["Car"]}, {reader["DriverPhone"]}, {reader["JoinDate"]}");
                    }
                }
                connection.Close();
            }
        }
        private void btnReportByGuardian_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            string query = "SELECT Driver, JoinDate FROM garden WHERE Car = ?";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Car", txtReportGuardianName.Text);
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxResults.Items.Add($"{reader["Driver"]}, {reader["JoinDate"]}");
                    }
                }
                connection.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            string query = "SELECT Driver, Car, DriverPhone, JoinDate FROM garden WHERE Driver LIKE ?";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Driver", "%" + txtSearch.Text + "%");
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxResults.Items.Add($"{reader["Driver"]}, {reader["Car"]}, {reader["DriverPhone"]}, {reader["JoinDate"]}");
                    }
                }
                connection.Close();
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
