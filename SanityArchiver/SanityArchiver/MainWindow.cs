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
        public MainWindow()
        {
            InitializeComponent();
            // Populate left side of the window with the tree-view of folders
            filesTreeView.Nodes.Add(TreeNodeLoader.PopulateTreeView(@"../.."));
        }

        void filesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            filesListView.Items.Clear();
            List<ListViewItem> allItemsInCurrentDir = DirectoryLoader.LoadSelectedDirInfo(e);
            foreach (ListViewItem listViewItem in allItemsInCurrentDir)
            {
                filesListView.Items.Add(listViewItem);
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
