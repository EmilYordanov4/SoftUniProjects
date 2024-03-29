﻿using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double goodGradeScholarship = Math.Floor(grade * 25);
            double socialScholarship = Math.Floor(minSalary * 0.35);

            if (income < minSalary && grade > 4.50 && grade < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income < minSalary && grade <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income >= minSalary && grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {goodGradeScholarship} BGN");
            }
            else if (income >= minSalary && grade < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minSalary && grade >= 5.50 && socialScholarship > goodGradeScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income < minSalary && grade >= 5.50 && goodGradeScholarship > socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {goodGradeScholarship} BGN");
            }
        }
    }
}