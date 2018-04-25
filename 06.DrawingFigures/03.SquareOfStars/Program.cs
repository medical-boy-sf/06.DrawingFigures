using System;

namespace _03.SquareOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n-1; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
