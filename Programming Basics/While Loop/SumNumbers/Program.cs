﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum <= number)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
                if (sum >= number)
                {
                    Console.WriteLine(sum);
                    Environment.Exit(0);
                }
            }
        }       
    }
}
