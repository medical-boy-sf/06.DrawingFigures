using System;

namespace _04.TriangleOfDollarsCS
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int k = 1; k <= i - 1; k++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
