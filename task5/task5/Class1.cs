using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        protected string SchoolName { get; set; }

        private string _internalCode = "ABC123";

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
