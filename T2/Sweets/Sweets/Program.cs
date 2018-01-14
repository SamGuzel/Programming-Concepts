using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sweets = 40, students = 14;

            int sweetsPerStudent = sweets / students;
            int sweetsForTeacher = sweets % students;
            Console.WriteLine("The sweets for each student would be : {0}", sweetsPerStudent);
            Console.WriteLine("The sweets left for the teacher would be: {0}", sweetsForTeacher);
            Console.ReadLine();
        }
    }
}
