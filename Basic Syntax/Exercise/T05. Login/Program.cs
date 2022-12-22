using System;

namespace T05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];
                password += currentChar;
            }

            string enteredPassword = Console.ReadLine();
            int incorrectInput = 0;
            while (enteredPassword != password)
            {
                incorrectInput++;
                if (incorrectInput >= 4)
                {
                    Console.WriteLine($"User { username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                enteredPassword = Console.ReadLine();
            }

            if (enteredPassword == password && incorrectInput < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
