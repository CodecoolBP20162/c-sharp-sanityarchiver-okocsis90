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
using ArchiverLogic;

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
            filesListView.Items.Clear();
            DirectoryInfo currentDirInfo = (DirectoryInfo) e.Node.Tag;
            foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(currentDirInfo))
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            // Populate left side of the window with the tree-view of folders
            searchBar.Text = defaultHomeFolder;
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(defaultHomeFolder));

        }

        private void getIntoBtn_Click(object sender, EventArgs e)
        {
            string pathToGo = String.Format(@"{0}\", searchBar.Text);
            
            filesTreeView.Nodes.Clear();
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(pathToGo));

            filesListView.Items.Clear();
            foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(new DirectoryInfo(pathToGo)))
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            string currentAddress = searchBar.Text;
            try
            {
                int index = currentAddress.Substring(0, currentAddress.Length - 1).LastIndexOf(@"\");
                if (index >= 0)
                {
                    searchBar.Text = currentAddress.Substring(0, index + 1);
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nowhere to go back.");
            }


            try
            {
                filesTreeView.SelectedNode = filesTreeView.SelectedNode.Parent;
            }
            catch (NullReferenceException)
            {
                filesTreeView.Nodes.Clear();
                filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(searchBar.Text));
            }
            

            filesListView.Items.Clear();
            foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(new DirectoryInfo(searchBar.Text)))
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pathToGo = String.Format(@"{0}\", searchBar.Text);

                filesTreeView.Nodes.Clear();
                filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(pathToGo));

                filesListView.Items.Clear();
                foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(new DirectoryInfo(pathToGo)))
                {
                    filesListView.Items.Add(listViewItem);
                }
                filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void filesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string actualPath;
            if (searchBar.Text.LastIndexOf(@"\") == searchBar.Text.Length - 1)
            {
                actualPath = searchBar.Text.Substring(0, searchBar.Text.Length - 1);
            }
            else
            {
                actualPath = searchBar.Text;
            }

            string pathToShow = String.Format(@"{0}\{1}", actualPath, filesListView.SelectedItems[0].Text);
            searchBar.Text = pathToShow;
            filesListView.Items.Clear();
            foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(new DirectoryInfo(pathToShow)))
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            filesTreeView.Nodes.Clear();
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(pathToShow));
        }
    }
}
