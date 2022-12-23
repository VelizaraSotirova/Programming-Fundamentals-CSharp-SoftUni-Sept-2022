using System;

namespace T01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNum = int.Parse(Console.ReadLine());
            
            if (dayNum <= 0 || dayNum > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }           
            Console.WriteLine(daysOfWeek[dayNum - 1]);
        }
    }
}
