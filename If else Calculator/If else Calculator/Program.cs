using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            double numb1 = short.Parse(Console.ReadLine());

            Console.WriteLine("enter symbol operation");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            double numb2 = short.Parse(Console.ReadLine());

            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/' || symbol == '%')
            {
                if (symbol == '+')
                {
                    Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}");
                }
                else if (symbol == '-')
                {
                    Console.WriteLine($"{numb1} - {numb2} = {numb1 - numb2}");
                }
                else if (symbol == '*')
                {
                    Console.WriteLine($"{numb1} * {numb2} = {numb1 * numb2}");
                }
                else if (symbol == '/')
                {
                    Console.WriteLine($"{numb1} / {numb2} = {numb1 / numb2}");
                }
                else if (symbol == '%')
                {
                    Console.WriteLine($"{numb1} % {numb2} = {numb1 % numb2}");
                }
            }
            else
            {
                Console.WriteLine("Wrong Symbol!!");
            }
          
        }
    }
}
