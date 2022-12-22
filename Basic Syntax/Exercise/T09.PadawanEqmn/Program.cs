using System;

namespace T09.PadawanEqmn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	The amount of money John has – floating-point number in the range [0.00…1000.00].
            //•	The count of students – integer in the range[0…100].
            //•	The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].
            //•	The price of robes for a single robe – floating - point number in the range[0.00…100.00].
            //•	The price of belts for a single belt – floating - point number in the range[0.00…100.00].
            double ownedMoney = double.Parse(Console.ReadLine());
            int studentsCnt = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int belts = studentsCnt / 6;
            double students10Percent = Math.Ceiling(studentsCnt * 0.1 + studentsCnt);

            totalPrice = (students10Percent * lightsabersPrice) + ((studentsCnt - belts) * beltsPrice) + (studentsCnt * robesPrice);

            if (ownedMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - ownedMoney:f2}lv more.");
            }
        }
    }
}
