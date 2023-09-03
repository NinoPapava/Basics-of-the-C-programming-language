using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operators
{
    internal class Program
    {
        static void Main()
        {
            int number1 = 10;
            int number2 = 20;

            double Dnumber1 = 30;
            double Dnumber2 = 20;
            //+
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
            //-
            sum = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {sum}");
            //*
            int multipli = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {multipli}");
            // /
            double divide = Dnumber1 / Dnumber2;
            Console.WriteLine($"{Dnumber1} / {Dnumber2} = {divide}");
            // %
            divide = number1 % number2;
            Console.WriteLine($"{number1} % {number2} = {divide}");
        }
    }
}
