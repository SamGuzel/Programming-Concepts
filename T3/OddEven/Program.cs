using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberInput ;
            //Declaring variabe

            Console.Write("Please input a whole number:  ");
            NumberInput = int.Parse(Console.ReadLine());
            //Asking for input of number and assigning it to the variable

            /* Checking variable saved  
            *Console.WriteLine("Number saved is:" + NumberInput);
            *Console.ReadLine();
            */

        if (NumberInput % 2 == 0) //Seeing if the number is dividable to 2 withot remainder
            {
                Console.WriteLine("The number {0} Number is Even", NumberInput);
            }
            else
            {
                Console.WriteLine("The Number {0} is Odd", NumberInput);
            }
            Console.ReadLine();

        }
    }
}
