using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring The Array
            var votes = new int[11];

            //Initialising the variables
            int VoteCount = 0;
            int TotalVotes = 0;
            int vote = 0;

            Console.WriteLine("Please rate your experience with C# out of 10 (Ensure you enter values between 0-10).");
            Console.WriteLine("Input -1 to stop voting");

            
            while (vote != -1) //Allows User to vote as much a s they like until the value becomes -1
            {
                vote = CheckVotes();
                if (vote > -1 && vote < 11)
                {
                    TotalVotes += vote;
                    VoteCount++;
                    votes[vote]++;
                }
                else if (vote == -1 && VoteCount < 1)
                {
                    vote = 0;
                    Console.WriteLine("Input a valid vote");
                    continue;
                }
                //Valid break
                else if (vote == -1 && VoteCount >= 1)
                {
                    break;
                }
                //Vote out of range
                else
                {
                    Console.WriteLine("Error! Give a rating between 0 and 10...");
                }
            }

            //Results table
            Console.WriteLine("{0, 15}{1, 15}", "RATING", "VOTES");
            Console.WriteLine("{0, 15}{1, 15}", 0, votes[0]);
            Console.WriteLine("{0, 15}{1, 15}", 1, votes[1]);
            Console.WriteLine("{0, 15}{1, 15}", 2, votes[2]);
            Console.WriteLine("{0, 15}{1, 15}", 3, votes[3]);
            Console.WriteLine("{0, 15}{1, 15}", 4, votes[4]);
            Console.WriteLine("{0, 15}{1, 15}", 5, votes[5]);
            Console.WriteLine("{0, 15}{1, 15}", 6, votes[6]);
            Console.WriteLine("{0, 15}{1, 15}", 7, votes[7]);
            Console.WriteLine("{0, 15}{1, 15}", 8, votes[8]);
            Console.WriteLine("{0, 15}{1, 15}", 9, votes[9]);
            Console.WriteLine("{0, 15}{1, 15}", 10, votes[10]);

            Console.WriteLine("\n{0, 15}{1, 15}", "AVERAGE:", TotalVotes / VoteCount);


            Console.ReadKey();
        }

        static int CheckVotes() //Checking the votes to make sure they are within the values
        {
            while (true)
            {
                try
                {
                    Console.Write("Vote: ");
                    var val = Convert.ToInt32(Console.ReadLine());
                    return val;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please re-enter your votes");
                }

            }
        }
    }
}