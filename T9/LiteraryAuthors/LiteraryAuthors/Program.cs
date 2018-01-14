using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            var authors = new[] { "William Shakespear", "Mark Twain", "Jane Austin", "Charlotte Bronte", "Louisa May Alcott", "Lewis Carroll", "D.H. Lawrence", "Charles Dickens", "Lucy Maud Montgomery", "Alexander Dumas" };
            Console.Write("Search for the author: ");
            var InputAuthor = Console.ReadLine();
            var AuthorFinder = Array.FindIndex(authors, name => name.Equals(InputAuthor, StringComparison.InvariantCultureIgnoreCase)); //important to ignore case
            AuthorFinder++;
            if (AuthorFinder == 0)
            {
                Console.WriteLine("No Record matches for that name please check spelling");
            }
            else
            {
                Console.WriteLine("MATCH! position in array: {0}", AuthorFinder);
            }
        }
    }
}