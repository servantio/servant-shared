using System;
using System.Security.Cryptography;
using System.Text;

namespace Servant.Shared.Helpers
{
    public static class CryptoHelper
    {
        public static string HashPassword(string clearTextPassword, string salt)
        {
            var algorithm = new SHA512Managed();
            var hashByte = algorithm.ComputeHash(Encoding.UTF8.GetBytes(clearTextPassword + salt));
            return Convert.ToBase64String(hashByte);
        }

        public static bool IsPasswordValid(string clearTextPassword, string salt, string hashedPassword)
        {
            if (hashedPassword == null)
                return false;

            return HashPassword(clearTextPassword, salt) == hashedPassword;
        }

        public static string ToMd5(string input)
        {
            // step 1, calculate MD5 hash from input
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            var sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString().ToLower();
        }
    }
}