using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerHand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int playerOneCardsCount = firstPlayerHand.Count;
            int playerTwoCardsCount = secondPlayerHand.Count;

            while (playerOneCardsCount > 0 && playerTwoCardsCount > 0)
            {
                if (firstPlayerHand[0] > secondPlayerHand[0])
                {
                    firstPlayerHand.Add(firstPlayerHand[0]);
                    firstPlayerHand.Add(secondPlayerHand[0]);
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }
                else if (secondPlayerHand[0] > firstPlayerHand[0])
                {
                    secondPlayerHand.Add(secondPlayerHand[0]);
                    secondPlayerHand.Add(firstPlayerHand[0]);
                    secondPlayerHand.RemoveAt(0);
                    firstPlayerHand.RemoveAt(0);
                }
                else if (firstPlayerHand[0] == secondPlayerHand[0])
                {
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }

                playerOneCardsCount = firstPlayerHand.Count;
                playerTwoCardsCount = secondPlayerHand.Count;
            }

            if (playerOneCardsCount > playerTwoCardsCount)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
            }
        }
    }
}
