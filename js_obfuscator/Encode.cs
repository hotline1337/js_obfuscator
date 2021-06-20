using System;
using System.Text;

namespace js_obfuscator
{
    class Encode
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string ToHexString(string str)
        {
            var sb = new StringBuilder();
            var encoding = Encoding.GetEncoding(1256);
            var bytes = encoding.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.AppendFormat("\\x{0:X2}", t);
            }
            return sb.ToString();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
