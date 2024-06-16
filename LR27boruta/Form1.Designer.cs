namespace LR27boruta
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.securityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(12, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(258, 492);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(512, 87);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(512, 131);
            this.textBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(258, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // securityTextBox
            // 
            this.securityTextBox.Location = new System.Drawing.Point(276, 482);
            this.securityTextBox.Multiline = true;
            this.securityTextBox.Name = "securityTextBox";
            this.securityTextBox.ReadOnly = true;
            this.securityTextBox.Size = new System.Drawing.Size(512, 64);
            this.securityTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editFileToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDirToolStripMenuItem,
            this.moveDirToolStripMenuItem,
            this.copyDirToolStripMenuItem,
            this.deleteDirToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // createDirToolStripMenuItem
            // 
            this.createDirToolStripMenuItem.Name = "createDirToolStripMenuItem";
            this.createDirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createDirToolStripMenuItem.Text = "Create Directory";
            this.createDirToolStripMenuItem.Click += new System.EventHandler(this.createDirToolStripMenuItem_Click);
            // 
            // moveDirToolStripMenuItem
            // 
            this.moveDirToolStripMenuItem.Name = "moveDirToolStripMenuItem";
            this.moveDirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveDirToolStripMenuItem.Text = "Move Directory";
            this.moveDirToolStripMenuItem.Click += new System.EventHandler(this.moveDirToolStripMenuItem_Click);
            // 
            // copyDirToolStripMenuItem
            // 
            this.copyDirToolStripMenuItem.Name = "copyDirToolStripMenuItem";
            this.copyDirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyDirToolStripMenuItem.Text = "Copy Directory";
            this.copyDirToolStripMenuItem.Click += new System.EventHandler(this.copyDirToolStripMenuItem_Click);
            // 
            // deleteDirToolStripMenuItem
            // 
            this.deleteDirToolStripMenuItem.Name = "deleteDirToolStripMenuItem";
            this.deleteDirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteDirToolStripMenuItem.Text = "Delete Directory";
            this.deleteDirToolStripMenuItem.Click += new System.EventHandler(this.deleteDirToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileToolStripMenuItem,
            this.moveFileToolStripMenuItem,
            this.copyFileToolStripMenuItem,
            this.pasteFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem,
            this.zipToolStripMenuItem,
            this.unzipToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createFileToolStripMenuItem.Text = "Create File";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // moveFileToolStripMenuItem
            // 
            this.moveFileToolStripMenuItem.Name = "moveFileToolStripMenuItem";
            this.moveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveFileToolStripMenuItem.Text = "Move File";
            this.moveFileToolStripMenuItem.Click += new System.EventHandler(this.moveFileToolStripMenuItem_Click);
            // 
            // copyFileToolStripMenuItem
            // 
            this.copyFileToolStripMenuItem.Name = "copyFileToolStripMenuItem";
            this.copyFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyFileToolStripMenuItem.Text = "Copy File";
            this.copyFileToolStripMenuItem.Click += new System.EventHandler(this.copyFileToolStripMenuItem_Click);
            // 
            // pasteFileToolStripMenuItem
            // 
            this.pasteFileToolStripMenuItem.Name = "pasteFileToolStripMenuItem";
            this.pasteFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteFileToolStripMenuItem.Text = "Paste File";
            this.pasteFileToolStripMenuItem.Click += new System.EventHandler(this.pasteFileToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete File";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zipToolStripMenuItem.Text = "Zip";
            this.zipToolStripMenuItem.Click += new System.EventHandler(this.zipToolStripMenuItem_Click);
            // 
            // unzipToolStripMenuItem
            // 
            this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            this.unzipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unzipToolStripMenuItem.Text = "Unzip";
            this.unzipToolStripMenuItem.Click += new System.EventHandler(this.unzipToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // editFileToolStripMenuItem
            // 
            this.editFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTextFileToolStripMenuItem,
            this.editAttributesToolStripMenuItem});
            this.editFileToolStripMenuItem.Name = "editFileToolStripMenuItem";
            this.editFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editFileToolStripMenuItem.Text = "Edit";
            // 
            // editTextFileToolStripMenuItem
            // 
            this.editTextFileToolStripMenuItem.Name = "editTextFileToolStripMenuItem";
            this.editTextFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTextFileToolStripMenuItem.Text = "Edit Text File";
            this.editTextFileToolStripMenuItem.Click += new System.EventHandler(this.editTextFileToolStripMenuItem_Click);
            // 
            // editAttributesToolStripMenuItem
            // 
            this.editAttributesToolStripMenuItem.Name = "editAttributesToolStripMenuItem";
            this.editAttributesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAttributesToolStripMenuItem.Text = "Edit Attributes";
            this.editAttributesToolStripMenuItem.Click += new System.EventHandler(this.editAttributesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.securityTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "File Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox securityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAttributesToolStripMenuItem;
    }
}
