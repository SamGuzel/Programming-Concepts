using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int smallest = numbers[0];
            int smallestPos = 0;
            for (int i = 0; i < 10; i++)

            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    smallestPos = i;
                }
            }
            Console.Write("The smallest number is:{0} at array position:{1}", smallest, smallestPos);
            Console.ReadLine();
        }
    }
}