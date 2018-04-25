using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main()
        {
            int n = inputMethod();

            Console.WriteLine(new String(' ', n + 1) + "|");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('*', i) + " | " + new String('*', i));
            }
        }

        private static int inputMethod()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
