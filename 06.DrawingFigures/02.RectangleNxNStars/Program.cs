﻿using System;

namespace _02.RectangleNxNStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
