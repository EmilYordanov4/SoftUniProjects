﻿using System;

namespace USDToBNG
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bng = usd * 1.79549;

            Console.WriteLine(bng);
        }
    }
}
