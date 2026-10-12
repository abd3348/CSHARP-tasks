using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Student
    {
        public string name;
        public int age;

        public double grade;

        public Student(string studentName, int studentAge, double studentGrade)
        {
            name = studentName;
            age = studentAge;
            grade = studentGrade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("grade: " + grade);

            Console.WriteLine("----------");
        }
    }
}
