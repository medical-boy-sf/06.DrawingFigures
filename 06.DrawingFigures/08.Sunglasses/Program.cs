using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());



            Console.WriteLine(new String('*', 2 * n) + new String(' ', n) + new String('*', 2 * n));

            for (int i = 1; i <= n - 2; i++)
            {
                if (n % 2 == 0 && i == n / 2 - 1)
                {
                    Console.WriteLine("*" + new String('/', 2 * n - 2) + "*" + new String('|', n) + "*" + new String('/', 2 * n - 2) + "*");
                }

                else if (n % 2 == 1 && i == Math.Floor(n / 2.0))
                {
                    Console.WriteLine("*" + new String('/', 2 * n - 2) + "*" + new String('|', n) + "*" + new String('/', 2 * n - 2) + "*");
                }

                else
                {


                    Console.WriteLine("*" + new String('/', 2 * n - 2) + "*" + new String(' ', n) + "*" + new String('/', 2 * n - 2) + "*");
                }
            }

            Console.WriteLine(new String('*', 2 * n) + new String(' ', n) + new String('*', 2 * n));

        }
    }
}
