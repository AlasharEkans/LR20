using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR27boruta
{ 

public partial class RenameForm : Form
{
    public string NewName { get; private set; }

    public RenameForm(string currentName)
    {
        InitializeComponent();
        textBoxNewName.Text = currentName;
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        NewName = textBoxNewName.Text;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

}
