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
                for (int j = 0; j < n; j++)
                {

                }
                Console.WriteLine(new String(' ', n - i) + new string('*', i));
            }
        }
    }
}
