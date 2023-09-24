using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join("\n", students));
        }

        class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
                StudentsList  = new List<string>();
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
            public List<string> StudentsList { get; set; }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:F2}";
            }
        }
    }
}
