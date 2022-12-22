using System;

namespace T04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutesAfter30Minutes = hours * 60 + minutes + 30;
            int hoursAfter30Min = totalMinutesAfter30Minutes / 60;
            int minutesAfter30Min = totalMinutesAfter30Minutes % 60;

            if (hoursAfter30Min > 23)
            {
                hoursAfter30Min -= 24; 
            }
            if (minutesAfter30Min > 59)
            {
                minutesAfter30Min -= 60;
            }

            if (minutesAfter30Min < 10)
            {
                Console.WriteLine($"{hoursAfter30Min}:{minutesAfter30Min:d2}");
            }
            else
            {
                Console.WriteLine($"{hoursAfter30Min}:{minutesAfter30Min}");
            }
        }
    }
}
