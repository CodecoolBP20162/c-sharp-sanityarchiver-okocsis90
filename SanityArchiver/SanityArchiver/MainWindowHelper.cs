using System;
using System.IO;
using System.Windows.Forms;
using SanityArchiverLogic;

namespace SanityArchiver
{
    public partial class MainWindow
    {
        /// <summary>
        /// This Method will update the ListView side of the window with all the folders and 
        /// files which are in the selected Directory.
        /// </summary>
        /// <param name="info">A DirectoryInfo</param>
        private void FillFileListView(DirectoryInfo info)
        {
            filesListView.Items.Clear();
            foreach (ListViewItem listViewItem in DirectoryLoader.LoadSelectedDirInfo(info))
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// This method Updates the list of Nodes in the TreeView part of the window.
        /// </summary>
        /// <param name="pathToGo">A string which shows the path of the node.</param>
        private void FillNodes(string pathToGo)
        {
            filesTreeView.Nodes.Clear();
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(pathToGo));
        }

        /// <summary>
        /// This method will Update the searchBar text if the user clicks on the back button.
        /// </summary>
        private void UpdateSearchBarTextWhenGoBack()
        {
            string path = PathModifier.CreateSearchBarText(searchBar.Text);
            if (path != null)
            {
                searchBar.Text = path;
            }
            else
            {
                MessageBox.Show("You are already in the root Directory.");
            }
        }

        /// <summary>
        /// Searches the parent node of the currently selected node, in order to Highlight it in 
        /// the event of going back. 
        /// </summary>
        private void LookForParentNodeToSelect()
        {
            try
            {
                filesTreeView.SelectedNode = filesTreeView.SelectedNode.Parent;
            }
            catch (NullReferenceException)
            {
                FillNodes(searchBar.Text);
            }
        }

        private void NavigateToDirIfExists()
        {
            string pathToGo = String.Format(@"{0}\", searchBar.Text);
            if (Directory.Exists(pathToGo))
            {
                FillFileListView(new DirectoryInfo(pathToGo));
                FillNodes(pathToGo);
            }
            else
            {
                MessageBox.Show("No such Folder. Go home, U R drunk!");
            }
        }
    }
}
