using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    //isGoing
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    guestList.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    //isNotGoing
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                    guestList.Remove(name);
                }
            }

            PrintGuests(guestList);
        }

        static void PrintGuests(List<string> guestList)
        {
            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
