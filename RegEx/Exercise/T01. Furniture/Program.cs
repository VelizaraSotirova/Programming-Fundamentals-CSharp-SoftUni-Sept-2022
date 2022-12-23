using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();

            string pattern = @">>(?<furnitureName>[A-za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}";
            string input;

            Regex regex = new Regex(pattern);
            double totalPrice = 0;


            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(furnitureName);
                    totalPrice += quantity * price;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
