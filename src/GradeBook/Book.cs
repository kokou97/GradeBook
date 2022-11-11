namespace GradeBook
{
    class Book
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
    }
}