using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Randomthrow = new Random();
            var Dice1 = 0;
            var Dice2 = 1;
            int NumberOfThrows = 0;

            //welcome the user and start the program
            Console.WriteLine("Welcome to the dice");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Rolling dice");

            while (Dice1 != Dice2)
            {
                Dice1 = Randomthrow.Next(1, 7);
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Dice 1 rolled a {0},", Dice1);
                Dice2 = Randomthrow.Next(1, 7);
                Console.WriteLine("Dice 2 rolled a {0},", Dice2);
                NumberOfThrows++;

            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("!! MATCH !! - The Dice took {0} Times to match,", NumberOfThrows);
            Console.ReadLine();
        }
    }
}