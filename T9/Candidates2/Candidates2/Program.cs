using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates2
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidates = new[] { "Ahmed", "Boo", "Celine", "Didi", "Elaine" };
            var votes = new int[5];

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

            Array.Sort(votes, candidates); //Sort Arrays
            Array.Reverse(votes); //Sort By Votes
            Array.Reverse(candidates); // Sort Names To Match Votes

            var first = new List<string>();
            var second = new List<string>();
            var third = new List<string>();

            int count = 0;
            int place = 0;
            int Sequence = 0;
           
            //Finding Person in First place
            foreach (var item in votes)
            {
                Sequence++;

                if (Sequence >= count && item == votes[place])
                {
                    try
                    {
                        first.Add(candidates[count]);
                        count++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }

                }
                else if (Sequence >= count && item != votes[place])
                {
                    place = count;
                    Sequence = 0;
                    break;
                }
            }
            //Find the Person in Second place
            foreach (var item in votes)
            {
                Sequence++;

                if (Sequence > count && item == votes[place])
                {
                    try
                    {
                        second.Add(candidates[count]);
                        count++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
                else if (Sequence > count && item != votes[place])
                {
                    place = count;
                    Sequence = 0;
                    break;
                }
            }
            //Finding the person in Third place
            foreach (var item in votes)
            {
                Sequence++;

                if (Sequence > count && item == votes[place])
                {
                    try
                    {
                        third.Add(candidates[count]);
                        count++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
                else if (Sequence > count && item != votes[place])
                {
                    place = count;
                    Sequence = 0;
                    break;
                }
            }


            Console.Write("First Place: ");
            foreach (var item in first)
            {
                Console.Write(item + " ");
            }
            Console.Write("Second Place: ");
            foreach (var item in second)
            {
                Console.Write(item + " ");
            }
            Console.Write("Third Place: ");
            foreach (var item in third)
            {
                Console.Write(item + " ");
            }

            //Vote summary
            Console.WriteLine("Outcome Of Votes ");
            Console.WriteLine();
            int i = 0;
            foreach (var item in candidates)
            {
                Console.WriteLine("{0, 10} {1, 10}", item, votes[i]);
                i++;
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}