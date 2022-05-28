using System.Security.Cryptography;
using System.Text;

namespace ExampleUsingHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pass = "teste";
            var pass2 = "teste";

            var passHash = GetHashString(pass);
            var passHash2 = GetHashString(pass2);

            Console.WriteLine("******* hash 1");
            Console.WriteLine(passHash);
            Console.WriteLine("******* hash 2");
            Console.WriteLine(passHash2);
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private static byte[] GetHash(string inputString)
        {
            using HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
    }
}