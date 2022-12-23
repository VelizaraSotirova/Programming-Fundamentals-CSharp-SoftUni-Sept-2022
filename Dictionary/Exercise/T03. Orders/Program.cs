using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders
                 = new Dictionary<string, List<double>>();

            string productInput = Console.ReadLine();

            while (productInput != "buy")
            {
                string[] productInfo = productInput
                    .Split(' ');

                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, new List<double>());
                    orders[productName].Add(productPrice);
                    orders[productName].Add(productQuantity);
                }
                else
                {
                    orders[productName][1] += productQuantity;
                    orders[productName][0] = productPrice;
                }

                productInput = Console.ReadLine();
            }

            foreach (var kvp in orders)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:f2}");
            }
        }
    }
}
