using System;
using System.Collections.Generic;


namespace GradeBook

{

    class Book
    {
        private List<double> grades;
        private string name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double HighestGrade()
        {
            var maxGrade = double.MinValue;

            foreach (var number in grades)
            {
                maxGrade = Math.Max(number, maxGrade);
            }
            return maxGrade;
        }

        public double LowestGrade()
        {
            var minGrade = double.MaxValue;

            foreach (var number in grades)
            {
                minGrade = Math.Min(number, minGrade);
            }
            return minGrade;
        }

        public double AverageGrade()
        {
            var avg = 0.0;
            foreach (var number in grades)
            {
                avg += number;
            }
            return avg / grades.Count;
        }

        public void ShowStats(){
            System.Console.WriteLine($"La calificacion mas alta fue: {this.HighestGrade():N2}");
            System.Console.WriteLine($"La calificacion mas baja fue: {this.LowestGrade():N2}");
            System.Console.WriteLine($"La calificacion promedio fue: {this.AverageGrade():N2}");
        }

    }
}