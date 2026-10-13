using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("abdallah", 22, 99);
            Student stu2 = new Student("ahmad", 24, 97.9);
            Student stu3 = new Student("omar", 22, 89.3);
            stu1.DisplayInfo();
            stu2.DisplayInfo();
            stu3.DisplayInfo();
        }
    }
}
