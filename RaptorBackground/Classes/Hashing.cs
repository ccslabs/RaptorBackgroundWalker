using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RaptorBackground.Classes
{
    class Hashing
    {

        internal string HashPassword(string password)
        {
            byte[] hash= null;
            var data = Encoding.UTF8.GetBytes(password);
            using (SHA512 shaM = new SHA512Managed())
            {
               hash = shaM.ComputeHash(data);
            }

            return BytesToString(hash);
        }

        internal string BytesToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "").ToUpper();
        }

        internal byte[] StringToBytes(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
