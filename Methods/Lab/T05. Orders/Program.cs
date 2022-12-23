using System;

namespace T05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            CalculateSum(productName, productQuantity);
        }
        static void CalculateSum(string productName, int productQuantity)
        {
            double sum = 0;    
            switch (productName)
            {
                case "coffee":
                    sum = productQuantity * 1.5;
                    break;
                case "water":
                    sum = productQuantity * 1;
                    break;
                case "coke":
                    sum = productQuantity * 1.4;
                    break;
                case "snacks":
                    sum = productQuantity * 2;
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
