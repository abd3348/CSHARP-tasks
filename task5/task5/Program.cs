using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(
                "Ahmad", 18, "Orange School", 95, 101
            );

            Student student2 = new Student(
                "Omar", 17, "Orange School", 88, 102
            );

            Teacher teacher = new Teacher(
                "Ali", 35, "Orange School", "Mathematics"
            );

            Console.WriteLine("=== Student 1 ===");
            student1.DisplayInfo();

            Console.WriteLine("\n=== Student 2 ===");
            student2.DisplayStudentInfo();

            Console.WriteLine("\n=== Teacher ===");
            teacher.DisplayTeacherInfo();

            Console.WriteLine("\n=== School Report ===");

            SchoolReport report =
                new SchoolReport("Final Exam Results");

            report.DisplayReportTitle();

            // Protected
            // Console.WriteLine(student1.SchoolName);

            // Private
            // Console.WriteLine(student1._internalCode);
        }
    } 
}