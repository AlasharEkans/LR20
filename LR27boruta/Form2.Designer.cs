
namespace LR27boruta

{ 
    partial class EditAttributesForm
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
        this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
        this.checkBoxHidden = new System.Windows.Forms.CheckBox();
        this.checkBoxSystem = new System.Windows.Forms.CheckBox();
        this.checkBoxArchive = new System.Windows.Forms.CheckBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.buttonCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // checkBoxReadOnly
        // 
        this.checkBoxReadOnly.AutoSize = true;
        this.checkBoxReadOnly.Location = new System.Drawing.Point(12, 12);
        this.checkBoxReadOnly.Name = "checkBoxReadOnly";
        this.checkBoxReadOnly.Size = new System.Drawing.Size(75, 17);
        this.checkBoxReadOnly.TabIndex = 0;
        this.checkBoxReadOnly.Text = "Read Only";
        this.checkBoxReadOnly.UseVisualStyleBackColor = true;
        // 
        // checkBoxHidden
        // 
        this.checkBoxHidden.AutoSize = true;
        this.checkBoxHidden.Location = new System.Drawing.Point(12, 35);
        this.checkBoxHidden.Name = "checkBoxHidden";
        this.checkBoxHidden.Size = new System.Drawing.Size(60, 17);
        this.checkBoxHidden.TabIndex = 1;
        this.checkBoxHidden.Text = "Hidden";
        this.checkBoxHidden.UseVisualStyleBackColor = true;
        // 
        // checkBoxSystem
        // 
        this.checkBoxSystem.AutoSize = true;
        this.checkBoxSystem.Location = new System.Drawing.Point(12, 58);
        this.checkBoxSystem.Name = "checkBoxSystem";
        this.checkBoxSystem.Size = new System.Drawing.Size(60, 17);
        this.checkBoxSystem.TabIndex = 2;
        this.checkBoxSystem.Text = "System";
        this.checkBoxSystem.UseVisualStyleBackColor = true;
        // 
        // checkBoxArchive
        // 
        this.checkBoxArchive.AutoSize = true;
        this.checkBoxArchive.Location = new System.Drawing.Point(12, 81);
        this.checkBoxArchive.Name = "checkBoxArchive";
        this.checkBoxArchive.Size = new System.Drawing.Size(62, 17);
        this.checkBoxArchive.TabIndex = 3;
        this.checkBoxArchive.Text = "Archive";
        this.checkBoxArchive.UseVisualStyleBackColor = true;
        // 
        // buttonOK
        // 
        this.buttonOK.Location = new System.Drawing.Point(12, 104);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(75, 23);
        this.buttonOK.TabIndex = 4;
        this.buttonOK.Text = "OK";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new System.Drawing.Point(93, 104);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(75, 23);
        this.buttonCancel.TabIndex = 5;
        this.buttonCancel.Text = "Cancel";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
        // 
        // EditAttributesForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(180, 139);
        this.Controls.Add(this.buttonCancel);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.checkBoxArchive);
        this.Controls.Add(this.checkBoxSystem);
        this.Controls.Add(this.checkBoxHidden);
        this.Controls.Add(this.checkBoxReadOnly);
        this.Name = "EditAttributesForm";
        this.Text = "Edit Attributes";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.CheckBox checkBoxReadOnly;
    private System.Windows.Forms.CheckBox checkBoxHidden;
    private System.Windows.Forms.CheckBox checkBoxSystem;
    private System.Windows.Forms.CheckBox checkBoxArchive;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
}
}
