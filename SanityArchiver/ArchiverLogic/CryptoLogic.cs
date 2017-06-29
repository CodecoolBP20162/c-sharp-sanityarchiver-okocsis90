using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiverLogic
{
    public class CryptoLogic
    {
        private static string sKey = GenerateKey();

        private static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        public static void EncryptFile(string source, string destination)
        {
            FileStream inputFileStream = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream encryptedFileStream = new FileStream(destination, FileMode.Create, FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();

            CryptoStream cryptostream = new CryptoStream(encryptedFileStream, desencrypt, CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[inputFileStream.Length - 1];
            inputFileStream.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

            cryptostream.Close();
            inputFileStream.Close();
            encryptedFileStream.Close();
        }

        public static void DecryptFile(string source, string destination)
        {


            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            FileStream fileStreamToRead = new FileStream(source, FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();

            CryptoStream cryptoStreamDecr = new CryptoStream(fileStreamToRead, desdecrypt, CryptoStreamMode.Read);

            StreamWriter decrypted = new StreamWriter(destination);
            decrypted.Write(new StreamReader(cryptoStreamDecr).ReadToEnd());
            decrypted.Flush();

            decrypted.Close();
            cryptoStreamDecr.Close();
            fileStreamToRead.Close();
        }
    }
}
