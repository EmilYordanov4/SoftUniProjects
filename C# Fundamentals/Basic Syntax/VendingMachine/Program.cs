﻿using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalBudget = 0;

            while (input != "Start")
            {
                double money = double.Parse(input);
                while (money != 0)
                {
                    if (money == 2)
                    {
                        totalBudget += 2;
                        money -= 2;
                    }
                    else if (money == 1)
                    {
                        totalBudget += 1;
                        money -= 1;
                    }
                    else if (money == 0.5)
                    {
                        totalBudget += 0.5;
                        money -= 0.5;
                    }
                    else if (money == 0.2)
                    {
                        totalBudget += 0.2;
                        money -= 0.2;
                    }
                    else if (money == 0.1)
                    {
                        totalBudget += 0.1;
                        money -= 0.1;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {money}");
                        money -= money;
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Nuts" && totalBudget >= 2.0)
                {
                    totalBudget -= 2;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (input == "Water" && totalBudget >= 0.7)
                {
                    totalBudget -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (input == "Crisps" && totalBudget >= 1.5)
                {
                    totalBudget -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (input == "Soda" && totalBudget >= 0.8)
                {
                    totalBudget -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else if (input == "Coke" && totalBudget >= 1.0)
                {
                    totalBudget -= 1.0;
                    Console.WriteLine($"Purchased coke");
                }
                else if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke")
                {
                    Console.WriteLine($"Invalid product");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalBudget:F2}");
        }
    }
}
