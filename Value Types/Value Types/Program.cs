using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    internal class Program
    {
        static void Main()
        {
            //bool type
            bool boolean = true;
            Console.WriteLine(boolean);

            bool boolean2 = false;
            Console.WriteLine(boolean2);

            //Integer types
            int number = 10;
            Console.WriteLine(number);

            byte smallnumber = 255;
            Console.WriteLine(smallnumber);

            long Long = 213213123213;
            Console.WriteLine(Long);

            sbyte Sbyte = 20;
            Console.WriteLine(Sbyte);

            short shortNumber = 1000;
            Console.WriteLine(shortNumber);

            //Decimal number types
            decimal Decimal = 2013.2012M;
            Console.WriteLine(Decimal);

            double doubleNumber = 23.87;
            Console.WriteLine(doubleNumber);

            float floatNumber = 32.80F;
            Console.WriteLine(floatNumber);

            //Symbols type
            char symbol = '&';
            Console.WriteLine(symbol);

            //Text types
            string text = "P@$SWORD";
            Console.WriteLine(text);
        }
    }
}
