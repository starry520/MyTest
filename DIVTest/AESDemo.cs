using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using DIVTest;

namespace ConsoleApplication2
{
    public class AESDemo
    {
        //public static RijndaelManaged GetRijndaelManaged(String secretKey, int secretKeyLength)
        //{
        //    var secretKeyBytes = new byte[secretKeyLength];
        //    var ivBytes = new byte[16];
        //    int blockSize = ivBytes.Length * 8;
        //    //secretKey = secretKey.Replace("-","");
        //    var keyBytes = Encoding.UTF8.GetBytes(secretKey);
        //    Array.Copy(keyBytes, secretKeyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
        //    return new RijndaelManaged
        //    {
        //        Mode = CipherMode.CBC,
        //        Padding = PaddingMode.PKCS7,
        //        KeySize = secretKeyLength*8,
        //        BlockSize = blockSize,
        //        Key = secretKeyBytes,
        //        IV = ivBytes
        //    };
        //}

        //public static byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged)
        //{
        //    return rijndaelManaged.CreateEncryptor()
        //        .TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        //}

        //public static byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged)
        //{
        //    return rijndaelManaged.CreateDecryptor()
        //        .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        //}

        ///// <summary>
        ///// Encrypts plaintext using AES 128bit key and a Chain Block Cipher and returns a base64 encoded string
        ///// </summary>
        ///// <param name="plainText">Plain text to encrypt</param>
        ///// <param name="key">Secret key</param>
        ///// <returns>Base64 encoded string</returns>
        //public static String Encrypt(String plainText, String key, int keySize)
        //{
        //    var plainBytes = Encoding.UTF8.GetBytes(plainText);
        //    return Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(key, keySize)));
        //}

        ///// <summary>
        ///// Decrypts a base64 encoded string using the given key (AES 128bit key and a Chain Block Cipher)
        ///// </summary>
        ///// <param name="encryptedText">Base64 Encoded String</param>
        ///// <param name="key">Secret Key</param>
        ///// <returns>Decrypted String</returns>
        //public static String Decrypt(String encryptedText, String key, int keySize)
        //{
        //    var encryptedBytes = Convert.FromBase64String(encryptedText);
        //    return Encoding.UTF8.GetString(Decrypt(encryptedBytes, GetRijndaelManaged(key, keySize)));
        //}

        //默认密钥向量 
        private static byte[] _key1 = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>
        /// AES加密算法
        /// </summary>
        /// <param name="plainText">明文字符串</param>
        /// <returns>将加密后的密文转换为Base64编码，以便显示</returns>
        public static string AESEncrypt(string plainText)
        {
            //分组加密算法
            SymmetricAlgorithm des = Rijndael.Create();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);//得到需要加密的字节数组 
            //设置密钥及密钥向量
            des.Key = Encoding.UTF8.GetBytes(Key);
            des.IV = _key1;
            byte[] cipherBytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cipherBytes = ms.ToArray();//得到加密后的字节数组
                    cs.Close();
                    ms.Close();
                }
            }

            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 获取密钥
        /// </summary>
        private static string Key
        {
            get
            {
                return "78B31088F0E44A86";    ////必须是16位
            }
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="cipherText">密文字符串</param>
        /// <returns>返回解密后的明文字符串</returns>
        public static string AESDecrypt(string showText)
        {
            byte[] cipherText = Convert.FromBase64String(showText);
            SymmetricAlgorithm des = Rijndael.Create();
            des.Key = Encoding.UTF8.GetBytes(Key);
            des.IV = _key1;
            byte[] decryptBytes = new byte[cipherText.Length];
            using (MemoryStream ms = new MemoryStream(cipherText))
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.Read(decryptBytes, 0, decryptBytes.Length);
                    cs.Close();
                    ms.Close();
                }
            }

            return Encoding.UTF8.GetString(decryptBytes).Replace("\0", "");   ///将字符串后尾的'\0'去掉
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            linq.Test();
            string s = SysConfigKeyEnum.AlertLowHotelCount.ToString();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 2000; i++)
            {
                sb.Append(i + ",");
            }
            //DeserializeObject("group.xml");
            testAes();
        }

        private static void testAes()
        {
            Dictionary<string, string> sss = new Dictionary<string, string>();
            sss.Add("123", null);
            if (sss["123"]==null)
            {
                
            }
            string text = "Method=GetFeedBackCountOfToday&Token=78B31088F0E44A8678B31088F0E44A86&HotelCode=18119"; //明文
            string keys = "78B31088F0E44A86";//secretKey
            //变换成32字节
            keys = keys.Replace("-", "");
            string after = AESDemo.AESEncrypt("78B31088F0E44A8678B31088F0E44A86");
            string stoken = "Fxw4qrM/ouujI/FoLx2nXAh1mXfUDqd0+JqYc+KHQJaUv64KQVt7cYTzbo4iOMT4";
            //将加密后的密文转换为Base64编码，以便显示，可以查看下结果
            Console.WriteLine("明文:" + text);
            Console.WriteLine("密文:" + after);
            //after = "oK+H1OtKelkhymDANy703A==";
            //解密
            string de = AESDemo.AESDecrypt(after);
            //将解密后的结果转换为字符串,也可以将该步骤封装在解密算法中
            Console.WriteLine("解密结果：" + de);
            Console.Read();
        }

      
    }

    public enum SysConfigKeyEnum
    {
        /// <summary>
        /// 批量预警的酒店数量
        /// </summary>
        AlertLowHotelCount

    }
}
