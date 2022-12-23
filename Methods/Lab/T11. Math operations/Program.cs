using System;

namespace T11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string chOperator = Console.ReadLine();
            string secondNum = Console.ReadLine();

            int result = GetResultOfMath(firstNum, chOperator, secondNum);
            Console.WriteLine(result);
        }
        static int GetResultOfMath(string firstNum, string chOperator, string secondNum)
        {
            int firstNumber = int.Parse(firstNum);  
            int secondNumber = int.Parse(secondNum);

            int result = 0;

            switch (chOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
