using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Type 1 For Bills, 2 for Circulars, 3 For Postcards or 4 For Personal Letters: "  );
            int TypeOfLetter = Convert.ToInt32(Console.ReadLine());

            if (TypeOfLetter < 1 && TypeOfLetter > 4)
            {
                Console.WriteLine("I'm sorry your entry is not recognised please try again");
                
            }

            switch (TypeOfLetter)
            {
                case 1:
                    Console.Write("Bills must be paid");
                    break;
                case 2:
                    Console.Write("Circulars are thrown away");
                    break;
                case 3:
                    Console.Write("Postcards are put on the wall");
                    break;
                case 4:
                    Console.Write("Personal letters are read and have replies written for them");
                    break;
            }
            Console.ReadKey();


        }
    }
}
