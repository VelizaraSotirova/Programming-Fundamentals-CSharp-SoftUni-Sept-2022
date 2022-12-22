using System;

namespace T03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        price = 8.45 * peopleCnt;
                    }
                    else if (groupType == "Business")
                    {
                        price = 10.9 * peopleCnt;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 15 * peopleCnt;
                    }
                    break;

                case "Saturday":
                    if (groupType == "Students")
                    {
                        price = 9.8 * peopleCnt;
                    }
                    else if (groupType == "Business")
                    {
                        price = 15.6 * peopleCnt;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 20 * peopleCnt;
                    }
                    break;

                case "Sunday":
                    if (groupType == "Students")
                    {
                        price = 10.46 * peopleCnt;
                    }
                    else if (groupType == "Business")
                    {
                        price = 16 * peopleCnt;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 22.5 * peopleCnt;
                    }
                    break;
            }

            //•	For Students – if the group is 30 or more people, you should reduce the total price by 15%.
            //•	For Business – if the group is 100 or more people, 10 of the people stay for free.
            //•	For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.
            if (groupType == "Students" && peopleCnt >= 30)
            {
                price -= price * 0.15;
            }
            if (groupType == "Business" && peopleCnt >= 100)
            {
                double priceFor10People = 0;
                if (dayOfWeek == "Friday")
                {
                    priceFor10People = 10 * 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceFor10People = 10 * 15.6;
                }
                else
                {
                    priceFor10People = 10 * 16;
                }
                price -= priceFor10People;
            }
            if (groupType == "Regular" && (peopleCnt >= 10 && peopleCnt <= 20))
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
