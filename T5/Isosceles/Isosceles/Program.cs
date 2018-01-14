using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles
{
    class Program
    {
        static void Main()
        {
            Console.Write("Whats the length of the isosceles triangle?: ");
            var length = Convert.ToInt32(Console.ReadLine());
            //taking the wanted length
            var spacer = "";
            var row = "";

            for (int l = length; l > 0; l --)
            {
                row = "";
                for (int a = length; a > 0; a--)
                {
                    row += "* ";
                }
                Console.WriteLine(spacer + row);
                spacer += " ";
                length--;
                //This way theres spacing and every row has 1 less to make it a triangle.
            }

            Console.Read();

        }
    }
}