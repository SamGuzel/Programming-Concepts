using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidateNames = new[] { "Ahmed", "Boo", "Celine", "Didi", "Elaine" };
            // Inputing Candidates into array
            var votes = new int[5];
            // Declare Array for votes
            while (true)
            {
                Console.Write("Enter number of candidate you wish to vote for: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                votes[input]++;
            }

            
            Array.Sort(votes, candidateNames); //Sort Arrays
            Array.Reverse(votes); //Sort by Votes
            Array.Reverse(candidateNames); // Sort Names to match votes
            Console.WriteLine("Outcome of Votes: ");
            Console.WriteLine();
            int i = 0;
            foreach (var item in candidateNames)
            {
                Console.WriteLine("{0, 10} {1, 10}", item, votes[i]);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("In first place: {0}", candidateNames[0]);
            Console.WriteLine("In second place: {0}", candidateNames[1]);
            Console.WriteLine("In third place: {0}", candidateNames[2]);

        }
    }
}