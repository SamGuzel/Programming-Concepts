
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the GradeInput: ");
            string GradeInput = Console.ReadLine();

            //Validation
            if (!String.Equals(GradeInput, "a", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(GradeInput, "b", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(GradeInput, "c", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(GradeInput, "d", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(GradeInput, "e", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please enter a valid Grade.\nValid grades: A, B, C, D or E");
                Console.ReadLine();
            }
            else if (String.Equals(GradeInput, "a", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Grade A means you scored between 70% and 100%");
            }
            else if (String.Equals(GradeInput, "b", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Grade B means you scored between 60% and 69%");
            }
            else if (String.Equals(GradeInput, "c", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Grade C means you scored between 50% and 59%");
            }
            else if (String.Equals(GradeInput, "d", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Grade D means you scored between 40% and 49%");
            }
            else if (String.Equals(GradeInput, "e", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Grade E means you scored between 0% and 39%");
            }


        }
    }
}