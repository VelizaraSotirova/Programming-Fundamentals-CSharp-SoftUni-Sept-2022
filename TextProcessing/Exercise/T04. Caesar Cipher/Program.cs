using System;
using System.Text;

namespace T04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string text = Console.ReadLine();
            EncryptedVersion(sb, text);
        }

        private static void EncryptedVersion(StringBuilder sb, string text)
        {
            foreach (char item in text)
            {
                int currPosition = item;
                currPosition += 3;
                sb.Append((char)currPosition);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
