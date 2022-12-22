using System;

namespace T10.RageExpense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first input line – lost games count – integer in the range [0…1000].
            //•	On the second line – headset price – floating - point number in the range[0…1000].
            //•	On the third line – mouse price – floating - point number in the range[0…1000].
            //•	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            //•	On the fifth line – display price – floating - point number in the range[0… 1000].
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadset = 0;
            int brokenMouse = 0;
            int brokenKeyboard = 0;
            int brokenDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHeadset++;
                }
                if (i % 3 == 0)
                {
                    brokenMouse++;
                }
                if (i % 6 == 0)
                {
                    brokenKeyboard++;
                }
                if (i % 12 == 0)
                {
                    brokenDisplay++;
                }
            }


            double totalExpenses = brokenHeadset * headsetPrice + brokenMouse * mousePrice + brokenKeyboard * keyboardPrice + brokenDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
