using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            const double AdultTicket = 10.50;
            const double ChildTicket = 7.30;
            const double ConcessionTicket = 8.40;
            double TotalBill;
            int NumAdult;
            int NumChild;
            int NumConcess;
            bool PostAndPack;
            double FreeAdults;
            //Declaring constants and variables

            //finding out how many tickets needed
            Console.Write("Please Input Number of Adults  ");
            NumAdult = int.Parse(Console.ReadLine());
            Console.Write("Please Input Number of Children  ");
            NumChild = int.Parse(Console.ReadLine());
            Console.Write("Please Input Number of Consessions  ");
            NumConcess = int.Parse(Console.ReadLine());
            //Console.Write("Do you Need Postage and Packaging (1=Yes/2=No)"  );
            //PostAndPack = bool.Parse(Console.ReadLine());
            //Working out discounts

            FreeAdults = NumChild / 10;
            if (FreeAdults > NumAdult)
            {
                TotalBill = (ChildTicket * NumChild) + (ConcessionTicket * NumConcess);
                FreeAdults = NumAdult;
            }
            else
            {
                TotalBill = (ChildTicket * NumChild) + (AdultTicket * ((NumAdult - FreeAdults))) + (ConcessionTicket * NumConcess);              

            }
        }
    }
}
