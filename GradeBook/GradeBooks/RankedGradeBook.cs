using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(String name, bool weighted) : base(name, weighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }
       
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();
            int place=0;
            foreach(Student student in Students)
            {
                if (averageGrade > student.AverageGrade) place++;
            }
            float avg = (float)place / (float)Students.Count*100;
            if (avg >= 80)
                return 'A';
            else if (avg >= 60)
                return 'B';
            else if (avg >= 40)
                return 'C';
            else if (avg >= 20)
                return 'D';
            else
                return 'F';
        }
        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
