using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiverLogic
{
    public class TreeNodeLoader
    {
        public static TreeNode PopulateTreeView(string path)
        {
            TreeNode rootNode = new TreeNode();

            DirectoryInfo info = new DirectoryInfo(path);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name, 0, 0);
                rootNode.Tag = info;
            }
            return rootNode;
        }

        public static void GetCurrentDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode newNode;

            foreach (DirectoryInfo subDir in subDirs)
            {
                newNode = new TreeNode(subDir.Name, 0, 0);
                newNode.Tag = subDir;

                nodeToAddTo.Nodes.Add(newNode);
            }

        }
    }
}
