using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_while
{
    internal class Program
    {
        static void Main()
        {
            int number = 10;

            while (number >= 0)
            {
                Console.WriteLine($"number is {number}");
                number--;
            }

            string symbol = "y";

            while (symbol == "y") {
                Console.WriteLine("while");
                Console.WriteLine("if  you want repeat enter y");
                symbol = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("do while cycle");
                Console.WriteLine("if  you want repeat enter y");
                symbol = Console.ReadLine();
            } while (symbol == "y");
        }
    }
}
