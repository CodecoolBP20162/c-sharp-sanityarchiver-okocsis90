using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            string pathToGo = String.Format(@"{0}\", searchBar.Text);
            FillNodes(pathToGo);
            FillFileListView(new DirectoryInfo(pathToGo));
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
                string pathToGo = String.Format(@"{0}\", searchBar.Text);
                FillNodes(pathToGo);
                FillFileListView(new DirectoryInfo(pathToGo));
            }
        }

        private void filesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string pathToShow = String.Format(@"{0}\{1}", PathModifier.RemoveLastBackSlash(searchBar.Text), filesListView.SelectedItems[0].Text);
            searchBar.Text = pathToShow;
            FillFileListView(new DirectoryInfo(pathToShow));
            FillNodes(pathToShow);
        }
    }
}
