using System;

namespace T04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Assume that a year has 365.2422 days on average 
            short century = short.Parse(Console.ReadLine());
            int years = century * 100;
            int days = (int)(years * 365.2422);
            long hours = days *  24;
            long minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
