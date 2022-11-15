namespace GradeBook
{
    public class Book
    {
        //List<double> grades = new List<double>();
        private List<double> grades;
        private string name;
        public Book(String name)
        {
            this.grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {

            var result = GetStatistics();

            Console.WriteLine($"Here start {this.name}'s book statistics : \n");
            Console.WriteLine($"This is the highGrade: {result.High}");
            Console.WriteLine($"This is the lowGrade: {result.Low}");
            Console.WriteLine($"The average grade is : {result.Average:N1}" + "\n");
            Console.WriteLine($"Here end {this.name}'s book statistics : \n \n");

        }

        public Statistics GetStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;
            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;
            return new Statistics(lowGrade, highGrade, result);

        }
    }

}