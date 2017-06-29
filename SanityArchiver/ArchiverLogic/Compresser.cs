using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiverLogic
{
    public class Compresser
    {
        public static void ArchiveFile(DirectoryInfo archiveDir, FileInfo fileToArchive)
        {
            try
            {
                FileStream input = File.Open(fileToArchive.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                FileStream output = File.Create(archiveDir.FullName + @"\" + DateTime.Now.ToString("yyyyMMddHHmmss") + fileToArchive.Name + ".gz");
                GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
                int b = input.ReadByte();
                while (b != -1)
                {
                    Compressor.WriteByte((byte)b);
                    b = input.ReadByte();
                }
                Compressor.Close();
                input.Close();
                output.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have the rights to Compress this file.");
            }
            catch (Exception)
            {
                MessageBox.Show("Oops, something went wrong. You probably should go home now.");
            }
        }
    }
}
