﻿using System;

namespace GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 )
                {
                    if (i == s)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
