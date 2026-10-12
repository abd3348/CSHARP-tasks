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
            Student s1 = new Student("Sara", 20,33.3);
            Student s2 = new Student("Ahmad", 22,55.5);
            Student s3 = new Student("Lina", 19,64.3);

            s1.DisplayInfo();

            s2.DisplayInfo();

            s3.DisplayInfo();
        }
    }
}
