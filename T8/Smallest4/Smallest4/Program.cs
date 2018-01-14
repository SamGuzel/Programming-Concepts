using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 numbers separated by a space");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int small = smaller(numbers);
            Console.WriteLine("The smallest number is: {0}", small);
            Console.ReadLine();

        }
        private static int smaller(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 0; i < 4; i++)
            {
                if (smallest > numbers[i])
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }
    }
}