using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, length, height, surfaceArea, volume;
            //width
            Console.WriteLine("Please enter the width of the cube");
            width = int.Parse(Console.ReadLine());
            //height
            Console.WriteLine("Please enter the length of the cube");
            length = int.Parse(Console.ReadLine());
            //length
            Console.WriteLine("Please enter the height of the cube");
            height = int.Parse(Console.ReadLine());
            //calc
            volume = width * height * length;
            surfaceArea = 2 * ((height * width) + (height * length) + (width * length));
            //show calc
            Console.WriteLine("volume: {0},surface area: {1}", volume, surfaceArea);
            Console.ReadLine();
        }
    }
}
