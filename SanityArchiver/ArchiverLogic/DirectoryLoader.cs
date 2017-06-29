using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiverLogic
{
    public class DirectoryLoader
    {
        static List<ListViewItem> allItems = new List<ListViewItem>();
        private static long sizeOfCurrentDir;

        // This method counts the size of a Directory. Unfortunately it is very slow, if it is needed
        // uncomment the commented line in LoadDirectories Method. 
        static long CountSizeOfFiles(DirectoryInfo dir)
        {
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    sizeOfCurrentDir += file.Length;
                }
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    CountSizeOfFiles(subDir);
                }

            }
            catch (UnauthorizedAccessException)
            {
            }
            return sizeOfCurrentDir;
        }

        public static void LoadDirectories(DirectoryInfo nodeDirInfo)
        {
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                sizeOfCurrentDir = 0;
                ListViewItem item = new ListViewItem(dir.Name, 0);
                ListViewItem.ListViewSubItem[] subItems = {new ListViewItem.ListViewSubItem(item, "Directory"),
                                                           new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
//                                                           ,new ListViewItem.ListViewSubItem(item, CountSizeOfFiles(dir).ToString())
                };
                item.SubItems.AddRange(subItems);
                allItems.Add(item);
            }
        }

        public static void LoadFiles(DirectoryInfo nodeDirInfo)
        {
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name, 1);
                ListViewItem.ListViewSubItem[] subItems = {new ListViewItem.ListViewSubItem(item, "File"),
                                                           new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                                                           new ListViewItem.ListViewSubItem(item, (file.Length / 1000) + " Kb")};
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
