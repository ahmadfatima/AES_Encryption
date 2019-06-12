using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AES_Encryption
{
    class AES
    {
        // Types Of AES Encryption
        public static string ECB_Encryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.ECB;
            aes128.Padding = PaddingMode.PKCS7;
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Encoding.Default.GetBytes(text);
            byte[] result1 = aes128.CreateEncryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Convert.ToBase64String(result1);
        }

        public static string CBC_Encryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.CBC;
            aes128.Padding = PaddingMode.Zeros;
            aes128.IV = Encoding.ASCII.GetBytes(key);
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Encoding.Default.GetBytes(text);
            byte[] result1 = aes128.CreateEncryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Convert.ToBase64String(result1);
        }

        public static string CFB_Encryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.CFB;
            aes128.Padding = PaddingMode.Zeros;
            aes128.IV = Encoding.ASCII.GetBytes(key);
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Encoding.Default.GetBytes(text);
            byte[] result1 = aes128.CreateEncryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Convert.ToBase64String(result1);
        }


        // Types Of AES Decryption
        public static string ECB_Decryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.ECB;
            aes128.Padding = PaddingMode.PKCS7;
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Convert.FromBase64String(text);
            byte[] result1 = aes128.CreateDecryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Encoding.Default.GetString(result1);
        }

        public static string CBC_Decryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.CBC;
            aes128.Padding = PaddingMode.Zeros;
            aes128.IV = Encoding.ASCII.GetBytes(key);
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Convert.FromBase64String(text);
            byte[] result1 = aes128.CreateDecryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Encoding.Default.GetString(result1);
        }

        public static string CFB_Decryption(string text, string key)
        {
            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.CFB;
            aes128.Padding = PaddingMode.Zeros;
            aes128.IV = Encoding.ASCII.GetBytes(key);
            aes128.Key = Encoding.ASCII.GetBytes(key);
            byte[] data1 = Convert.FromBase64String(text);
            byte[] result1 = aes128.CreateDecryptor().TransformFinalBlock(data1, 0, data1.Length);
            return Encoding.Default.GetString(result1);
        }

    }
}

