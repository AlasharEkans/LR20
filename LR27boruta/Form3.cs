using System;
using System.IO;
using System.Windows.Forms;

namespace LR27boruta
{
    public partial class EditTextForm : Form
    {
        private string filePath;
        public bool FileUpdated { get; private set; }

        public EditTextForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            textBoxContent.Text = File.ReadAllText(filePath);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, textBoxContent.Text);
            FileUpdated = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
