using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main()
        {
            const string UserPass = "chickendinner";
            string EnteredPass;
            //declaring constant and variables

            Console.Write("Please Enter your Password (Case sensitive)  ");
            EnteredPass = Console.ReadLine();
            //Asking for password

            if (UserPass == EnteredPass) //If password input is correct then.. else...
            {
                Console.WriteLine("Welcome User!");
                Console.ReadLine();
                //If password is correct output welcome
            }
            else
            {
                Console.WriteLine("Sorry That Was Not correct try again");
                Console.ReadLine();
                //IF incorrect notify and restart program
                Main();
            }

        }

    }
}
