﻿using System;

namespace NumbersDividedBy3WithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
