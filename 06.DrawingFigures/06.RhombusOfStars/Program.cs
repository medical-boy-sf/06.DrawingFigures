using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n - 1; i++)
            {
                for (int k = 0; k <= i - 1; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int j = n - i; j > 1; j--)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

        }
    }
}
