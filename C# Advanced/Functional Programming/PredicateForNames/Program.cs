﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            names = names.Where(x => x.Length <= n).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
