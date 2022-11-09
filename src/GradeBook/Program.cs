using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            var y = 10.3;
            var z = x + y;
            Console.WriteLine((z));
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