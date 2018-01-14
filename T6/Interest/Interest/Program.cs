using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    class Program
    {
        static void Main()
        {
            
            int YearsToWait = 0;
            
                Console.Write("Please Input Current Balance:  ");
                var CurrentBal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please Input Required Balance:  ");
                var RequiredBal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please Input Interest Rate:  ");
                var InterestRate = Convert.ToDouble(Console.ReadLine());

                while (CurrentBal < RequiredBal)
                {
                    CurrentBal *= ((InterestRate / 100) + 1);
                    YearsToWait++;
                }
            Console.WriteLine("It would take you {0} years to reach your required balance of £{1} ", YearsToWait, RequiredBal);
            Console.ReadLine();
        }
    }
}
