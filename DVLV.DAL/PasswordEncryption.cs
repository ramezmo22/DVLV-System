using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DVLV.DAL
{
    public class PasswordEncryption
    {
        private static readonly string EncryptionKey = "b7f3c9a8d6e4f1b2c3d5e7f9a1b4c6d8"; // مفتاح التشفير (يجب أن يكون سريًا)

        // تشفير النص
        public static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32)); // تحويل المفتاح إلى 32 بايت
                aes.IV = new byte[16]; // كتلة التهيئة (IV) - يمكن أن تكون ثابتة أو عشوائية

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(memoryStream.ToArray()); // تحويل البيانات المشفرة إلى Base64
                }
            }
        }

        // فك التشفير
        public static string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32)); // تحويل المفتاح إلى 32 بايت
                aes.IV = new byte[16]; // كتلة التهيئة (IV) - يجب أن تكون نفس القيمة المستخدمة في التشفير

                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cryptoStream))
                        {
                            return reader.ReadToEnd(); // استعادة النص الأصلي
                        }
                    }
                }
            }
        }
    }
}
        
