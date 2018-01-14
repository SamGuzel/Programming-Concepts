using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayCheck
{
    class Program
    {
        static void Main()
        {
            int DaysGoing = 0;
            int NumGuest = 0;
            int Board = 0;

            NumDays();
            GuestNumbers();
            BoardType();
            // Calling up another method
            void NumDays()
            {
                try //Try and catch to validate syntax errors
                {
                    Console.Write("How long do you wish to go for (2,7 or 14 nights?)  ");
                    DaysGoing = int.Parse(Console.ReadLine());
                    //IF statements below to validate any errors
                    if (DaysGoing != 2 && DaysGoing != 7 && DaysGoing != 14)
                    {
                        Console.Write("I'm sorry you have not entered a valid number of days press enter and try again");
                        Console.ReadLine();
                        Main();
                    }
                    else{}
                }
                catch
                {
                    Console.Write("I'm sorry you have not entered a valid number of days press enter and try again");
                    Console.ReadLine();
                    NumDays();
                }
            }
           void GuestNumbers() //Another method to find Number of guests
            {
                try
                {
                    Console.Write("How Many Guests are going?  ");
                   NumGuest = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Sorry thats not a valid number of guests, try again");
                    GuestNumbers();
                }
            }

            void BoardType()
                {
                try
                {
                    Console.Write("What board? (1 for Full, 2 For Half Or 3 for Self-catering)  ");
                    Board = int.Parse(Console.ReadLine());


                    //IF statements below to validate any errors
                    if (Board != 1 && Board != 2 && Board != 3)
                    {
                        Console.WriteLine("I'm sorry you have not entered a valid Board type please try again by pressing enter");
                        BoardType();
                    }
                    else {}
                }
                catch
                {
                    Console.WriteLine("Error, Invalid board type selected try again");
                    BoardType();
                }
            }
            Console.Write("Booking has been created, enjoy your holiday!");
            Console.ReadLine();
        }
    }      
 }
   
