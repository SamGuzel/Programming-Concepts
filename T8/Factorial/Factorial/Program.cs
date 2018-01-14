using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = Factorial(input);
            Console.WriteLine("The factorial of {0} is {1}", input, factorial);
        }

        static int Factorial(int num)
        {
            var factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}