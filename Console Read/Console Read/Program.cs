using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Read
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, what is your firstname ?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, what is your lastname ?");
            string lastname = Console.ReadLine();

            Console.WriteLine($"{name} {lastname}");
        }
    }
}
