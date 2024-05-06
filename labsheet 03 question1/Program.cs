
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args);
            public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            public Course(string courseName)
            {
                if (string.IsNullOrEmpty(courseName))
                {
                    throw new ArgumentException("Course name cannot be empty or null.");
                }
                this.courseName = courseName;
            }

            public string CourseName => courseName;

            public string Grade
            {
                get
                {
                    return CalculateLetterGrade();
                }
            }

            public void SetInstructorName(string instructorName)
            {
                if (string.IsNullOrEmpty(instructorName))
                {
                    throw new ArgumentException("Instructor name cannot be empty or null.");
                }
                this.instructorName = instructorName;
            }

            private string CalculateLetterGrade()
            {
                if (grade < 0 || grade > 100)
                {
                    throw new ArgumentException("Grade must be between 0 and 100.");
                }
                if (grade >= 90)
                {
                    return "A";
                }
                else if (grade >= 80)
                {
                    return "B";
                }
                else if (grade >= 70)
                {
                    return "C";
                }
                else if (grade >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }

            public void SetGrade(double grade)
            {
                if (grade < 0 || grade > 100)
                {
                    throw new ArgumentException("Grade must be between 0 and 100.");
                }
                this.grade = grade;
            }

            public void PrintCourseInfo()
            {
                Console.WriteLine($"Course: {CourseName}");
                Console.WriteLine($"Instructor: {instructorName}");
                Console.WriteLine($"Letter Grade: {Grade}");
            }
        }
    }
}