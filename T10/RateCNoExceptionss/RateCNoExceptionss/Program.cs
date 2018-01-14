using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCNoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int[] inputs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            while (!end)
            {
                Console.WriteLine("Please Rate the Java programming language using a number in the range 0 - 10. or -1 to stop");
                int input;
                bool canConvert = int.TryParse(Console.ReadLine(), out input);
                if (canConvert)
                {
                    if (input == -1)
                    {
                        end = true;
                        if (inputs.Count() == 0)
                        {
                            Console.WriteLine("You havent entered any numbers?");
                        }
                    }
                    else if (input >= 0 && input <= 10)
                    {
                        inputs[input]++;
                    }
                    else
                    {
                        Console.WriteLine("Please Re-enter a Number between 0 & 10");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Either no number was entered or a letter has been entered");
                    Console.WriteLine("");
                }


            }

            if (inputs.Sum() != 0)
            {
                //average
                int count = 0;
                int average = 0;
                int total = 0;
                for (var i = 0; i < inputs.Length; i++)
                {
                    count = count + inputs[i];
                    total = total + (i * inputs[i]);
                }

                average = total / inputs.Sum();

               
                Console.WriteLine("{0, -20}{1, -20}", "rating", "frequency");         
                for (var i = 0; i < inputs.Length; i++)
                {
                    Console.WriteLine($"{i,-20}{inputs[i],-20}");
                }              
                Console.WriteLine($"Average :{average,-20}");                
            }
            else
            {
                Console.Write("No entries have been made so no calculations can commence.");
            }

            Console.ReadLine();
        }
    }
}
