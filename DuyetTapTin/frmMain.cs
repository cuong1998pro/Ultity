using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DuyetTapTin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();
            trvDirectory.BeginUpdate();
            foreach (string strDrive in drives)
            {
                TreeNode nodeDrive = new TreeNode(strDrive.Remove(2, 1));
                trvDirectory.Nodes.Add(nodeDrive);
            }
            trvDirectory.EndUpdate();
        }

        private void AddDirectories(TreeNode subNode)
        {
            trvDirectory.BeginUpdate();
            try
            {
                DirectoryInfo diRoot;
                diRoot = new DirectoryInfo(subNode.FullPath.ToString());

                DirectoryInfo[] dirs = diRoot.GetDirectories();
                subNode.Nodes.Clear();
                foreach (DirectoryInfo dir in dirs)
                {
                    TreeNode node = new TreeNode(dir.Name);
                    subNode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
                MessageBox.Show("Loi");
            }
            trvDirectory.EndUpdate();
        }

        private void AddFiles(string path)
        {
            lsvFile.BeginUpdate();
            try
            {
                lsvFile.Items.Clear();
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    string size = string.Empty;
                    if (file.Length >= 1024)
                    {
                        size = string.Format("{0:### ### ###} KB", file.Length / 1024);
                    }
                    else
                    {
                        size = string.Format("{0} Byte", file.Length);
                    }
                    string time = file.LastWriteTime.ToString("dd/MM/yyyy");
                    string shortTime = file.LastWriteTime.ToShortDateString();

                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(size);
                    item.SubItems.Add(time);
                    item.SubItems.Add(shortTime);
                    lsvFile.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
                MessageBox.Show("lOI");
            }
            lsvFile.EndUpdate();
        }

        private void trvDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            AddDirectories(e.Node);
            trvDirectory.SelectedNode.Expand();
            AddFiles(e.Node.FullPath.ToString());
        }

        private void lsvFile_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                string path = trvDirectory.SelectedNode.FullPath;
                string fileName = lsvFile.FocusedItem.Text;
                Process.Start(path + "\\" + fileName);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }
    }
}