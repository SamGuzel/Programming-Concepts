using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CaloriesFromCycling = 200;
            const int CaloriesFromRunning = 475;
            const int CaloriesFromSwimming = 275;
            const int poundPerCalories = 3500;
            //Declaring the constant values
            
            Console.Write("Please enter minutes spent cycling: ");
            int TSpentCycle = int.Parse(Console.ReadLine());
            Console.Write("Please enter minutes spent running: ");
            int TSpentRun = int.Parse(Console.ReadLine());
            Console.Write("Please enter minutes spent swimming: ");
            int TSpentSwim = int.Parse(Console.ReadLine());
            int totalTime = TSpentCycle + TSpentRun + TSpentSwim;
            //Inputting their times

            double cycleCal = ((double)TSpentCycle / 60) * CaloriesFromCycling;
            double runCal = ((double)TSpentRun / 60) * CaloriesFromRunning;
            double swimCal = ((double)TSpentSwim / 60) * CaloriesFromSwimming;
            double totalCal = cycleCal + runCal + swimCal;
            //Working  out their calories burnt

            double cycleWeight = cycleCal / poundPerCalories;
            double runWeight = runCal / poundPerCalories;
            double swimWeight = swimCal / poundPerCalories;
            double totalWeight = cycleWeight + runWeight + swimWeight;
            //Working out their weight loss

            //TimeSpan setup for hh:mm format in table
            TimeSpan timeSpanCycle = new TimeSpan(0, 0, TSpentCycle, 0);
            string timeCycle = null;
            timeCycle = timeSpanCycle.ToString(@"h\:mm");
            TimeSpan timeSpanRun = new TimeSpan(0, 0, TSpentRun, 0);
            string timeRun = null;
            timeRun = timeSpanRun.ToString(@"h\:mm");
            TimeSpan timeSpanSwim = new TimeSpan(0, 0, TSpentSwim, 0);
            string timeSwim = null;
            timeSwim = timeSpanSwim.ToString(@"h\:mm");
            TimeSpan timeSpanTotal = new TimeSpan(0, 0, totalTime, 0);
            string timeTotal = null;
            timeTotal = timeSpanTotal.ToString(@"h\:mm");

            //Table with results
            Console.WriteLine("\n{0, -20}{1, 20}{2, 20}{3, 20}\n ", "Activity", "Time Spent", "Calories Burnt", "Pounds Lost");
            Console.WriteLine("{0, -20}{1, 20}{2, 20}{3, 20}", "Cycling", timeCycle, cycleCal.ToString("F") + " kcal", cycleWeight.ToString("F") + " lb");
            Console.WriteLine("{0, -20}{1, 20}{2, 20}{3, 20}", "Running", timeRun, runCal.ToString("F") + " kcal", runWeight.ToString("F") + " lb");
            Console.WriteLine("{0, -20}{1, 20}{2, 20}{3, 20}\n", "Swimming", timeSwim, swimCal.ToString("F") + " kcal", swimWeight.ToString("F") + " lb");
            Console.WriteLine("{0, -20}{1, 20}{2, 20}{3, 20}\n", "Total", timeTotal, totalCal.ToString("F") + " kcal", totalWeight.ToString("F") + " lb");
            Console.ReadLine();
        }
    }
}
