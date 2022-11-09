﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 12.7, 10.3, 6.11 };
            numbers[0] += 5;
            Console.WriteLine(numbers.Sum());
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