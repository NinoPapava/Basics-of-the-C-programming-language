using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = "599111111";
            string number2 = "599222222";
            string number3 = "599333333";
            string number4 = "599444444";
            string number5 = "599543555";
            string number6 = "599454365";
            string number7 = "599754323";
            string number8 = "599563456";
            string number9 = "599655475";

            string[] numbers = 
            {
                number1,
                number2,
                number3,
                number4,
                number5,
                number6,
                number7,
                number8,
                number9,
                "577777"
            };

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
             }
        }
    }
}
