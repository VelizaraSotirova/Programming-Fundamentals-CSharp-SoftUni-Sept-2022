using System;

namespace T10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int vounter = 0;
            double originalN = n;

            while (n >= m)
            {
                vounter++;
                n -= m;

                if (originalN / 2 == n)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(vounter);
        }
    }
}