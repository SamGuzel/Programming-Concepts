using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboveAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfStudents;
            int avarage;
            int total = 0;

            Console.WriteLine("Enter Number of Students");
            NumOfStudents = int.Parse(Console.ReadLine());
            if (NumOfStudents > 0)
            {

                string[] StudentName = new string[NumOfStudents];
                int[] StudentGrade = new int[NumOfStudents];


                for (int i = 0; i < NumOfStudents; i++)
                {
                    Console.WriteLine("Write student Name");
                    StudentName[i] = Console.ReadLine();
                    Console.WriteLine("Write student Grade");
                    StudentGrade[i] = int.Parse(Console.ReadLine());
                    total = total + StudentGrade[i];
                }

                avarage = total / NumOfStudents;
                Console.WriteLine("The average grade is: {0}", avarage);
                Console.WriteLine("The following Students are above average:");

                for (int i = 0; i < NumOfStudents; i++)
                {
                    if (StudentGrade[i] > avarage)
                    {
                        Console.Write("{0} :", StudentName[i]);
                        Console.Write(" {0}", StudentGrade[i]);
                        Console.WriteLine();
                    }
                }


            }
            else
            {
                Console.WriteLine("error Number Of students is below 1");

            }

            Console.ReadLine();
        }
    }
}