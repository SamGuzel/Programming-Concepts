using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = 0;
            var width = 0;
            var Gridcreate = "";

            Console.Write("Whats the height of the grid?:  ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Whats the width of the grid?:  ");
            width = Convert.ToInt32(Console.ReadLine());

            for (int h = height; h > 0; h--)
            {
                Gridcreate = "";

            for (int w = width; w > 0; w--)
                {
                    Gridcreate += "* ";
                }
                Console.WriteLine(Gridcreate);
          
            }
            Console.ReadLine();
        }
    }
}
