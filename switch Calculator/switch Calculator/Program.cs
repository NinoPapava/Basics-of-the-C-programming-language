using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            double numb1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operation [+] [-] [*] [/] [%]");
            string operation = Console.ReadLine();

            Console.WriteLine("EnterSecond Number");
            double numb2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}");
                    break;
                case "-":
                    Console.WriteLine($"{numb1} - {numb2} = {numb1 - numb2}");
                    break;
                case "*":
                    Console.WriteLine($"{numb1} * {numb2} = {numb1 * numb2}");
                    break;
                case "/":
                    Console.WriteLine($"{numb1} / {numb2} = {numb1 / numb2}");
                    break;
                case "%":
                    Console.WriteLine($"{numb1} % {numb2} = {numb1 % numb2}");
                    break;

                default:
                    Console.WriteLine("Wrong Symbol !!!");
                    break;
            }
        }
    }
}
