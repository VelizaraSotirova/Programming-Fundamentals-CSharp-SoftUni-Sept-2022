using System;

namespace T05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int firstOperation = Add(numbers[0], numbers[1]);
            int lastOperation = Substract(firstOperation, numbers[2]);

            Console.WriteLine(lastOperation);
        }

        static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        static int Substract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
}
