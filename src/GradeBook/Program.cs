using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 10.3, 6.11 };
            var grades = new List<double>();
            grades.Add(56.1);
            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
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