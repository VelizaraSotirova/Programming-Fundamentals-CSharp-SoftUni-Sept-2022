using System;

namespace T09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());  

                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (dataType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string result = GetMax(firstString, secondString);
                Console.WriteLine(result);
            }
            else if (dataType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        static string GetMax(string firstValue, string secondValue)
        {
            int result = firstValue.CompareTo(secondValue);


            if (result > 0)
            {
                return firstValue;
            }
            return secondValue;
        }
    }
}
