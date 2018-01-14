using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPosNeg
{
    class Program
    {
        static void Main()
        {
            var positives = 0;
            var negatives = 0;
            var NumOfP = 0;
            var NumOfN = 0;

            //variables made to store totals
            Console.WriteLine("\nPlease enter 10 integers...");
            //requesting user input
            for (int i = 0; i < 10; i++) //looping 10 times to get 10 inputs
            {
                try
                {
                    Console.Write("Enter a Number (either positive or negative): ");
                    int input = Convert.ToInt32(Console.ReadLine()); //saving inputs
                    if (input < 0) 
                    {
                        negatives += input; // total negative inputs
                        NumOfN++;
                    }
                    else
                    {
                        positives += input; //Total positive inputs
                        NumOfP++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was not supported. Only enter whole numbers, if negative a simple -'number will do'");
                    Console.WriteLine("Click a key to continue");
                    Console.ReadKey();
                    Main();
                }

            }

            if (NumOfP > 0)
            {
                var AvgP = (positives / NumOfP);
                Console.WriteLine();
                Console.WriteLine("Positive Number sum is: {0}", positives);
                Console.WriteLine("Positive Number average is: {0}", AvgP);
            }
            else Console.WriteLine("No positive numbers");

            if (NumOfN > 0)
            {
                var AvgN = (negatives / NumOfN);
                Console.WriteLine();
                Console.WriteLine("Negative Number sum is: {0}", negatives);
                Console.WriteLine("Negative Number average is: {0}", AvgN);
            }
            else Console.WriteLine("No Negative Numbers");
            Console.WriteLine();
            Console.WriteLine("Click a key to close!");
            Console.ReadKey();


        }
    }
}
