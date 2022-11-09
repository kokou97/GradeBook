using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 10.3, 6.11 };
            var grades = new List<double>() { 12.7, 10.3, 6.11 };
            grades.Add(56.1);
            var result1 = 0.0;
            foreach (var number in numbers)
            {
                result1 += number;
            }
            var result2 = 0.0;
            int lenGrades = 0;
            foreach (var grade in grades)
            {
                result2 += grade;
                lenGrades += 1;
            }
            result2 /= lenGrades;
            Console.WriteLine(result1);
            Console.WriteLine(result2 + "\n");
            Console.WriteLine(grades.Sum());
            if (args.Length < 1)
            {
                Console.WriteLine("Hello, World!");
            }
            else
            {
                if (args.Length == 1)
                {
                    Console.WriteLine("Hello, " + args[0] + "!");
                }
                else
                {
                    Console.WriteLine("Hello, " + args[0] + "!");
                    Console.WriteLine($"{args[1]} is your sister!");
                }
            }
        }
    }
}