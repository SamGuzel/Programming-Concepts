using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height Input (in feet) then enter it then");
            Console.WriteLine("Height input (in inches) followed by enter again");
            int h = HeightInch();
            Console.WriteLine("Weight Input (in stone) then enter it then");
            Console.WriteLine("Weight Input (in pounds) and then enter it then\n");
            Console.WriteLine();
            int w = WeightPound();
            CalcBMI(h, w);
            Console.ReadLine();
        }

        //While loop which validates the user's input so that it is within a desired range
        static int ValidNum(int low, int high)
        {
            Console.WriteLine("Please input a number between {0} and {1}", low, high);
            int num = Convert.ToInt32(Console.ReadLine());
            while (num < low || num > high)
            {
                Console.WriteLine("INVALID INPUT\nPlease input a number between {0} and {1}", low, high);
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            return num;
        }

        static int HeightInch()
        {
            int feet = ValidNum(2, 7);
            int inches = ValidNum(0, 12);

            int total = (feet * 12) + inches;

            Console.WriteLine("Total height in inches is {0}", total);
            Console.WriteLine();

            return total;
        }

        static int WeightPound()
        {
            int stone = ValidNum(3, 30);
            int pounds = ValidNum(0, 13);

            int total = (stone * 14) + pounds;

            Console.WriteLine("Total weight in pounds is {0}", total);
            Console.WriteLine();

            return total;
        }

        static void CalcBMI(int height, int weight)
        {
            double BMI = (weight * 703) / (height * height);
            Console.WriteLine("Your BMI is {0}", BMI);
         
        }
       
    }
    
}
