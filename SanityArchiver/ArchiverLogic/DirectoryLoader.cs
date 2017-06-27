using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiverLogic
{
    public class DirectoryLoader
    {
        static List<ListViewItem> allItems = new List<ListViewItem>();

        static void LoadDirectories(DirectoryInfo nodeDirInfo)
        {
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                ListViewItem item = new ListViewItem(dir.Name, 0);
                ListViewItem.ListViewSubItem[] subItems = {new ListViewItem.ListViewSubItem(item, "Directory"),
                                                           new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                allItems.Add(item);
            }
        }

        static void LoadFiles(DirectoryInfo nodeDirInfo)
        {
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1);
                ListViewItem.ListViewSubItem[] subItems = {new ListViewItem.ListViewSubItem(item, "Directory"),
                                                           new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                allItems.Add(item);
            }
        }

        public static List<ListViewItem> LoadSelectedDirInfo(DirectoryInfo selectedDir)
        {
            allItems.Clear();

            try
            {
                LoadDirectories(selectedDir);
                LoadFiles(selectedDir);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to access this folder");
            }

            return allItems;
        }
    }
}
