using System;
using System.Collections.Generic;

namespace GradeBook // Note: actual namespace depends on the project name.
{

    class Program
    {
        static void Main(string[] args)
        {

            //Static methods cannot be instanciated
            Book book = new Book("JM's GradeBookbbbbc");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.1);

            book.ShowStatistics();

            // book.grades.Add(88.9);
            var numbers = new[] { 12.7, 10.3, 6.11 };
            var grades = new List<double>() { 12.7, 10.3, 6.11 };
            grades.Add(56.1);
            var result1 = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            Console.WriteLine($"This is the minimum value which is of type double: {highGrade}");
            foreach (var number in numbers)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result1 += number;
            }
            Console.WriteLine($"This is the highGrade: {highGrade}");
            Console.WriteLine($"This is the lowGrade: {lowGrade}");
            var result2 = 0.0;
            int lenGrades = 0;
            foreach (var grade in grades)
            {
                result2 += grade;
                lenGrades += 1;
            }
            Console.WriteLine($"The average grade is : {(result2 / grades.Count):N1}");
            result2 /= lenGrades;
            Console.WriteLine($"The sum of numbers is : {result1}");
            Console.WriteLine($"The average grade is : {result2}" + "\n");
            Console.WriteLine($"The sum of grades is : {grades.Sum()}");
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