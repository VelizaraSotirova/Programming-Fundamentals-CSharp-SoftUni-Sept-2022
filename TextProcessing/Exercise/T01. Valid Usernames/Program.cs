using System;

namespace T01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);


            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isUsernameValid = true;

                    foreach (char item in username)
                    {
                        if (!(char.IsLetterOrDigit(item) || item =='_' || item == '-'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }

                    if (isUsernameValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
