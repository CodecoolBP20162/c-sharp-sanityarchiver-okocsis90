using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanityArchiverLogic;

namespace SanityArchiver
{
    public partial class MainWindow : Form
    {
        private static string defaultHomeFolder = @"C:\";

        public MainWindow()
        {
            InitializeComponent();
        }

        void filesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DirectoryInfo currentDirInfo = (DirectoryInfo)e.Node.Tag;
            FillFileListView(currentDirInfo);
            try
            {
                TreeNodeLoader.GetCurrentDirectories(currentDirInfo.GetDirectories(), e.Node);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to access this folder");
            }

            searchBar.Text = currentDirInfo.FullName;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            searchBar.Text = defaultHomeFolder;
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(defaultHomeFolder));
        }

        private void getIntoBtn_Click(object sender, EventArgs e)
        {
            NavigateToDirIfExists();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            UpdateSearchBarTextWhenGoBack();
            LookForParentNodeToSelect();
            FillFileListView(new DirectoryInfo(searchBar.Text));
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToDirIfExists();
            }
        }

        private void filesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string pathToShow = String.Format(@"{0}\{1}", PathModifier.RemoveLastBackSlash(searchBar.Text), filesListView.SelectedItems[0].Text);
            if (Directory.Exists(pathToShow))
            {
                searchBar.Text = pathToShow;
                FillFileListView(new DirectoryInfo(pathToShow));
                FillNodes(pathToShow);
            }

        }

        private void filesListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (filesListView.FocusedItem.Bounds.Contains(e.Location) && filesListView.FocusedItem.SubItems[1].Text == "File")
                {
                    fileMenu.Show(Cursor.Position);
                }
            }
        }

        private void compressFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullName = PathModifier.RemoveLastBackSlash(searchBar.Text) + @"\" + filesListView.FocusedItem.Text;
            Compresser.ArchiveFile(new DirectoryInfo(searchBar.Text), new FileInfo(fullName));
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceName = PathModifier.RemoveLastBackSlash(searchBar.Text) + @"\" + filesListView.FocusedItem.Text;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                CryptoLogic.EncryptFile(sourceName, saveFile.FileName);
                MessageBox.Show("Succesfully Encrypted!");
            }
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceName = PathModifier.RemoveLastBackSlash(searchBar.Text) + @"\" + filesListView.FocusedItem.Text;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                CryptoLogic.DecryptFile(sourceName, saveFile.FileName);
                MessageBox.Show("Succesfully Dencrypted!");
            }
        }

    }
}
