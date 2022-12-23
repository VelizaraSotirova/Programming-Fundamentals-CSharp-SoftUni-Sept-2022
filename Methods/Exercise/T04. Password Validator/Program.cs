using System;

namespace T04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLengthValid = IsPasswordLengthValid(password);
            bool isPasswordAlphaNumeric = IsPasswordAlphaNumeric(password);
            bool isPaswordContainingAtLeastTwoDigits = IsPasswordContainingAtLeastTwoDigits(password);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPaswordContainingAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthValid && isPasswordAlphaNumeric && isPaswordContainingAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;

            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= 2;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
    }
}
