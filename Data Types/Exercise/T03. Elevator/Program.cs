using System;

namespace T03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (peopleNumber < elevatorCapacity)
            {
                Console.WriteLine("1");
            }
            else
            {
                int coursesSum = 0;
                int courses = (int)Math.Ceiling((decimal)peopleNumber / elevatorCapacity);
                coursesSum += courses;
                Console.WriteLine(coursesSum);
            }
        }
    }
}
