using System;
using System.IO;
using System.Windows.Forms;

namespace LR27boruta
{
    public partial class EditAttributesForm : Form
    {
        public FileAttributes Attributes { get; private set; }

        public EditAttributesForm(FileAttributes attributes)
        {
            InitializeComponent();
            Attributes = attributes;

            checkBoxReadOnly.Checked = attributes.HasFlag(FileAttributes.ReadOnly);
            checkBoxHidden.Checked = attributes.HasFlag(FileAttributes.Hidden);
            checkBoxSystem.Checked = attributes.HasFlag(FileAttributes.System);
            checkBoxArchive.Checked = attributes.HasFlag(FileAttributes.Archive);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Attributes = 0;
            if (checkBoxReadOnly.Checked) Attributes |= FileAttributes.ReadOnly;
            if (checkBoxHidden.Checked) Attributes |= FileAttributes.Hidden;
            if (checkBoxSystem.Checked) Attributes |= FileAttributes.System;
            if (checkBoxArchive.Checked) Attributes |= FileAttributes.Archive;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
