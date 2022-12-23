﻿using System;
using System.Text.RegularExpressions;

namespace T03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;

            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";
            Regex regex = new Regex(pattern);

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
