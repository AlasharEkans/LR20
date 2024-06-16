using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.IO.Compression;

namespace LR27boruta
{
    public partial class Form1 : Form
    {
        private string copiedFilePath;
        private bool isFileCopied;

        public Form1()
        {
            InitializeComponent();
            LoadDrives();
            treeView1.AfterExpand += new TreeViewEventHandler(this.treeView1_AfterExpand);
            treeView1.AfterCollapse += new TreeViewEventHandler(this.treeView1_AfterCollapse);
        }

        private void LoadDrives()
        {
            TreeNode rootNode;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                rootNode = new TreeNode(drive.Name);
                rootNode.Tag = drive;
                rootNode.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath);
                LoadDirectory(dir, e.Node);
            }
        }

        private void LoadDirectory(DirectoryInfo dir, TreeNode node)
        {
            try
            {
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDir.Name);
                    subNode.Tag = subDir;
                    subNode.Nodes.Add(new TreeNode());
                    node.Nodes.Add(subNode);
                }

                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;
                    node.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            pictureBox1.Image = null;
            securityTextBox.Clear();
            DisplayProperties(e.Node.Tag);
            DisplaySecurityProperties(e.Node.Tag);
            if (e.Node.Tag is FileInfo file)
            {
                if (file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    textBox2.Text = File.ReadAllText(file.FullName);
                }
                else if (file.Extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                         file.Extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                         file.Extension.Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                         file.Extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase) ||
                         file.Extension.Equals(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(file.FullName);
                    }
                    catch (Exception)
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            SearchAndHighlight();
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            SearchAndHighlight();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchAndHighlight();
        }

        private void SearchAndHighlight()
        {
            string searchText = searchTextBox.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                ClearHighlight(treeView1.Nodes);
                return;
            }

            foreach (TreeNode node in treeView1.Nodes)
            {
                SearchNode(node, searchText);
            }
        }

        private void SearchNode(TreeNode node, string searchText)
        {
            if (node.IsExpanded)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    SearchNode(subNode, searchText);
                }
            }

            if (node.Text.ToLower().Contains(searchText))
            {
                node.BackColor = Color.Yellow;
                HighlightText(node, searchText);
            }
            else
            {
                node.BackColor = Color.White;
                node.NodeFont = treeView1.Font;
            }
        }

        private void HighlightText(TreeNode node, string searchText)
        {
            int startIndex = node.Text.ToLower().IndexOf(searchText);
            if (startIndex >= 0)
            {
                Font highlightFont = new Font(treeView1.Font, FontStyle.Bold);
                node.NodeFont = highlightFont;
            }
            else
            {
                node.NodeFont = treeView1.Font;
            }
        }

        private void ClearHighlight(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.BackColor = Color.White;
                node.NodeFont = treeView1.Font;
                if (node.Nodes.Count > 0)
                {
                    ClearHighlight(node.Nodes);
                }
            }
        }

        private void DisplayProperties(object item)
        {
            textBox1.Clear();
            if (item is DriveInfo drive)
            {
                textBox1.AppendText($"Name: {drive.Name}\r\n");
                textBox1.AppendText($"Type: {drive.DriveType}\r\n");
                textBox1.AppendText($"Format: {drive.DriveFormat}\r\n");
                textBox1.AppendText($"AvailableSpace: {drive.AvailableFreeSpace}\r\n");
                textBox1.AppendText($"TotalSpace: {drive.TotalSize}\r\n");
            }
            else if (item is DirectoryInfo dir)
            {
                textBox1.AppendText($"Full Name: {dir.FullName}\r\n");
                textBox1.AppendText($"Creation Time: {dir.CreationTime}\r\n");
                textBox1.AppendText($"Attributes: {dir.Attributes}\r\n");
            }
            else if (item is FileInfo file)
            {
                textBox1.AppendText($"Full Name: {file.FullName}\r\n");
                textBox1.AppendText($"Size: {file.Length}\r\n");
                textBox1.AppendText($"Creation Time: {file.CreationTime}\r\n");
                textBox1.AppendText($"Attributes: {file.Attributes}\r\n");
            }
        }

        private void DisplaySecurityProperties(object item)
        {
            if (item is DirectoryInfo dir)
            {
                try
                {
                    DirectorySecurity security = dir.GetAccessControl();
                    DisplayAccessRules(security);
                }
                catch (UnauthorizedAccessException) { }
            }
            else if (item is FileInfo file)
            {
                try
                {
                    FileSecurity security = file.GetAccessControl();
                    DisplayAccessRules(security);
                }
                catch (UnauthorizedAccessException) { }
            }
        }

        private void DisplayAccessRules(FileSecurity security)
        {
            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            foreach (FileSystemAccessRule rule in rules)
            {
                securityTextBox.AppendText($"Identity: {rule.IdentityReference}\r\n");
                securityTextBox.AppendText($"Type: {rule.AccessControlType}\r\n");
                securityTextBox.AppendText($"Rights: {rule.FileSystemRights}\r\n");
                securityTextBox.AppendText($"Inherited: {rule.IsInherited}\r\n");
                securityTextBox.AppendText($"Inheritance Flags: {rule.InheritanceFlags}\r\n");
                securityTextBox.AppendText($"Propagation Flags: {rule.PropagationFlags}\r\n");
                securityTextBox.AppendText("\r\n");
            }
        }

        private void DisplayAccessRules(DirectorySecurity security)
        {
            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            foreach (FileSystemAccessRule rule in rules)
            {
                securityTextBox.AppendText($"Identity: {rule.IdentityReference}\r\n");
                securityTextBox.AppendText($"Type: {rule.AccessControlType}\r\n");
                securityTextBox.AppendText($"Rights: {rule.FileSystemRights}\r\n");
                securityTextBox.AppendText($"Inherited: {rule.IsInherited}\r\n");
                securityTextBox.AppendText($"Inheritance Flags: {rule.InheritanceFlags}\r\n");
                securityTextBox.AppendText($"Propagation Flags: {rule.PropagationFlags}\r\n");
                securityTextBox.AppendText("\r\n");
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
                contextMenuStrip.Show(treeView1, e.Location);
            }
        }

        private void createDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                string newDirPath = Path.Combine(dir.FullName, "New Folder");
                Directory.CreateDirectory(newDirPath);
                TreeNode newNode = new TreeNode("New Folder");
                newNode.Tag = new DirectoryInfo(newDirPath);
                treeView1.SelectedNode.Nodes.Add(newNode);
                treeView1.SelectedNode.Expand();
            }
        }

        private void moveDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = Path.Combine(folderBrowserDialog.SelectedPath, dir.Name);
                        Directory.Move(dir.FullName, destinationPath);
                        treeView1.SelectedNode.Remove();
                    }
                }
            }
        }

        private void copyDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                copiedFilePath = dir.FullName;
                isFileCopied = false;
            }
        }

        private void pasteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                if (!string.IsNullOrEmpty(copiedFilePath))
                {
                    string destinationPath = Path.Combine(dir.FullName, Path.GetFileName(copiedFilePath));
                    if (isFileCopied)
                    {
                        File.Copy(copiedFilePath, destinationPath);
                    }
                    else
                    {
                        CopyDirectory(copiedFilePath, destinationPath);
                    }
                    LoadDirectory(new DirectoryInfo(dir.FullName), treeView1.SelectedNode);
                    copiedFilePath = null;
                }
            }
        }

        private void deleteDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                Directory.Delete(dir.FullName, true);
                treeView1.SelectedNode.Remove();
            }
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo dir)
            {
                string newFilePath = Path.Combine(dir.FullName, "NewFile.txt");
                File.Create(newFilePath).Close();
                TreeNode newNode = new TreeNode("NewFile.txt");
                newNode.Tag = new FileInfo(newFilePath);
                treeView1.SelectedNode.Nodes.Add(newNode);
                treeView1.SelectedNode.Expand();
            }
        }

        private void moveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = Path.Combine(folderBrowserDialog.SelectedPath, file.Name);
                        File.Move(file.FullName, destinationPath);
                        treeView1.SelectedNode.Remove();
                    }
                }
            }
        }

        private void copyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file)
            {
                copiedFilePath = file.FullName;
                isFileCopied = true;
            }
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file)
            {
                File.Delete(file.FullName);
                treeView1.SelectedNode.Remove();
            }
        }

        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = Path.GetFileNameWithoutExtension(file.Name) + ".zip";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream zipToOpen = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                            {
                                archive.CreateEntryFromFile(file.FullName, file.Name);
                            }
                        }
                    }
                }
            }
        }

        private void unzipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file && file.Extension.Equals(".zip", StringComparison.OrdinalIgnoreCase))
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string extractPath = folderBrowserDialog.SelectedPath;
                        ZipFile.ExtractToDirectory(file.FullName, extractPath);
                    }
                }
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                object selectedItem = treeView1.SelectedNode.Tag;
                string currentName = treeView1.SelectedNode.Text;
                using (RenameForm form = new RenameForm(currentName))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string newName = form.NewName;
                        if (selectedItem is FileInfo file)
                        {
                            string newPath = Path.Combine(file.DirectoryName, newName);
                            File.Move(file.FullName, newPath);
                            treeView1.SelectedNode.Text = newName;
                            treeView1.SelectedNode.Tag = new FileInfo(newPath);
                        }
                        else if (selectedItem is DirectoryInfo dir)
                        {
                            string newPath = Path.Combine(dir.Parent.FullName, newName);
                            Directory.Move(dir.FullName, newPath);
                            treeView1.SelectedNode.Text = newName;
                            treeView1.SelectedNode.Tag = new DirectoryInfo(newPath);
                        }
                    }
                }
            }
        }

        private void editTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is FileInfo file && file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                using (EditTextForm form = new EditTextForm(file.FullName))
                {
                    form.ShowDialog();
                    if (form.FileUpdated)
                    {
                        textBox2.Text = File.ReadAllText(file.FullName);
                    }
                }
            }
        }

        private void editAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                object selectedItem = treeView1.SelectedNode.Tag;
                if (selectedItem is FileInfo file)
                {
                    FileAttributes attributes = file.Attributes;
                    using (EditAttributesForm form = new EditAttributesForm(attributes))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            file.Attributes = form.Attributes;
                        }
                    }
                }
                else if (selectedItem is DirectoryInfo dir)
                {
                    FileAttributes attributes = dir.Attributes;
                    using (EditAttributesForm form = new EditAttributesForm(attributes))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            dir.Attributes = form.Attributes;
                        }
                    }
                }
            }
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                Point pt = treeView1.PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = treeView1.GetNodeAt(pt);

                if (targetNode != null && targetNode.Tag is DirectoryInfo targetDir)
                {
                    if (draggedNode.Tag is FileInfo draggedFile)
                    {
                        string destPath = Path.Combine(targetDir.FullName, draggedFile.Name);
                        File.Move(draggedFile.FullName, destPath);
                        draggedNode.Remove();
                        targetNode.Nodes.Add(new TreeNode(draggedFile.Name) { Tag = new FileInfo(destPath) });
                    }
                    else if (draggedNode.Tag is DirectoryInfo draggedDir)
                    {
                        string destPath = Path.Combine(targetDir.FullName, draggedDir.Name);
                        Directory.Move(draggedDir.FullName, destPath);
                        draggedNode.Remove();
                        targetNode.Nodes.Add(new TreeNode(draggedDir.Name) { Tag = new DirectoryInfo(destPath) });
                    }
                    targetNode.Expand();
                }
            }
        }

        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            Directory.CreateDirectory(destinationDir);
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string dest = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, dest);
            }
            foreach (string folder in Directory.GetDirectories(sourceDir))
            {
                string dest = Path.Combine(destinationDir, Path.GetFileName(folder));
                CopyDirectory(folder, dest);
            }
        }
    }
}
