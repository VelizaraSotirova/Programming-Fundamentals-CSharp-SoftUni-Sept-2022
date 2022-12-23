using System;
using System.Linq;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int totalPassengers = 0;
            int[] passengers = new int[numberOfWagons];

            for (int i = 0; i < numberOfWagons; i++)
            {
                int passengersInEachWagon = int.Parse(Console.ReadLine());
                totalPassengers += passengersInEachWagon;

                passengers[i] = passengersInEachWagon;
            }

            Console.WriteLine(String.Join(" ", passengers));
            Console.WriteLine(totalPassengers);
        }
    }
}
