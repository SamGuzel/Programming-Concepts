using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatePercentage
{
    class Program
    {
        static void Main()
        {

            try
            { 
            Console.Write("Please enter a percentage between 0 - 100% (Just the number not '%'):  ");
            var Percentage = Int32.Parse(Console.ReadLine());
      
                while (Percentage < 0 || Percentage > 100)
                {
                    Console.WriteLine("Error Please enter a valid percentage from 0-100% (Just a whole number not including '%'):  ");
                    Percentage = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("You Have typed {0}%", Percentage);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Incorrect input try again");
                Main();
            }
           
        }
    }
}
