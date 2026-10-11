using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //int number = random.Next(50, 76);

            ////Console.WriteLine(number);

            //bool isTrue = false;
            //int counter = 0;
            //int points = 0;

            //while (!isTrue)
            //{
            //    Console.WriteLine("Guess a number between 50 and 75: ");
            //    int rnum = int.Parse(Console.ReadLine());
            //    counter++;
            //    if (rnum == number)
            //    {
            //        Console.WriteLine("Congratulations!");
            //        isTrue = true;
            //        break;
            //    }
            //    if (rnum > number)
            //    {
            //        Console.WriteLine("Try a lower number.");

            //    }
            //    else if (rnum < number)
            //    {
            //        Console.WriteLine("Try a higher number.");
            //    }
            //}

            //if (counter == 1)
            //{
            //    points = 10;
            //}
            //else if (counter == 2)
            //{
            //    points = 7;
            //}
            //else if (counter == 3)
            //{
            //    points = 5;
            //}
            //else
            //{
            //    points = 0;
            //}
            //Console.WriteLine("number of attempts: " + counter);
            //Console.WriteLine("your points is: " + points);


            ///////////////////////////////////////////////////////////////////////


            string[] students = { "abdallah", "ahmad", "omar", "ali", "moath" };
            int[] grades = { 55, 89, 99, 64, 80 };

            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Display Students
                        for (int j = 0; j < students.Length; j++)
                        {
                            Console.WriteLine(students[j]);
                        }

                        break;

                    case 2:
                        // Search for Student
                        bool isfound = false;
                        int i = 0;

                        Console.Write("Enter a student name: ");
                        string name = Console.ReadLine();

                        while (i < students.Length)
                        {
                            if (name == students[i])
                            {
                                isfound = true;
                                break;
                            }

                            i++;
                        }

                        if (isfound)
                        {
                            Console.WriteLine("Student Found!");
                        }
                        else
                        {
                            Console.WriteLine("Student Not Found.");
                        }

                        break;

                    case 3:
                        // Check Student Result
                        Console.Write("Enter a student's grade: ");
                        int x = int.Parse(Console.ReadLine());

                        if (x < 0 || x > 100)
                        {
                            Console.WriteLine("Invalid Grade");
                        }
                        else if (x >= 90)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (x >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (x >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (x >= 60)
                        {
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);





    }
    }
}
