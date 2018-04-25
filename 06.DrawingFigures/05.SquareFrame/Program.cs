using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // Upper Part
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            //Middle Part
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            // Lower Part
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
