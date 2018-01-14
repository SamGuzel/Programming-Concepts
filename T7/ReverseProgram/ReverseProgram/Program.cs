using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInputs = new int[10];

            Console.WriteLine("Please Enter 10 numbers (One number followed by enter each time");
            for (int i = 0;i< userInputs.Length; i++)
            {
                userInputs[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(userInputs);
            foreach (int value in userInputs)
            {
                Console.WriteLine(value);
            }
            
            Console.ReadLine();
            
        }
    }
}
