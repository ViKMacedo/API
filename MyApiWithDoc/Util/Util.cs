using System.Security.Cryptography;
using System.Text;

namespace API.Util
{
    public class Util
    {
        public static byte[] GetHash(string inputString)
        {
            using HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in (inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}