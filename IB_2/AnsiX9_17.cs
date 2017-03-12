using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace IB_2
{
    class AnsiX9_17
    {
        private static readonly Random rnd = new Random(); // create it just once and reuse
        private static ulong Get64BitRandom(ulong minValue, ulong maxValue)
        {
            // Get a random array of 8 bytes. 
            // As an option, you could also use the cryptography namespace stuff to generate a random byte[8]
            byte[] buffer = new byte[sizeof(ulong)];
            rnd.NextBytes(buffer);
            return BitConverter.ToUInt64(buffer, 0) % (maxValue - minValue + 1) + minValue;
        }

        public static List<ulong> generate(int m)
        {
            var date = DateTime.Now;
            var date_bin = date.ToBinary();
            ulong s = Get64BitRandom(ulong.MinValue, ulong.MaxValue-1);

            var myTripleDES = new TripleDESCryptoServiceProvider();

            var result = new List<ulong>();

            // Encrypt the string to an array of bytes.
            byte[] encrypted = EncryptStringToBytes(date_bin, myTripleDES.Key, myTripleDES.IV);
            ulong temp = BitConverter.ToUInt64(encrypted, 0);

            for (var i = 1; i <= m; ++i)
            {
                var x = BitConverter.ToUInt64(EncryptStringToBytes((long)(temp ^ s), myTripleDES.Key, myTripleDES.IV), 0);
                result.Add(x);
                s = BitConverter.ToUInt64(EncryptStringToBytes((long)(s ^ x), myTripleDES.Key, myTripleDES.IV), 0);
            }

            return result;
        }


        private static byte[] EncryptStringToBytes(long date_bin, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using (var tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(date_bin);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }
    }
}