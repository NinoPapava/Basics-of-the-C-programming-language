using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 22, 33, 44 };

            PrintCollection(numbers);

            int[] masivi = { 100, 200, 300, 400, 500 };
            PrintCollection(masivi);


            string[] names = { "nino", "gvantsa", "anna", "Tatia" };

            string name = GetName(names, 0);
            Console.WriteLine(name);
        }

        static void PrintCollection(int[] Arrays) 
        {
            foreach (int number in Arrays)
            {
                Console.WriteLine(number);
            }
        }

        static string GetName(string[] names, int index)
        {
            for (int i = 0; i < names.Length; i++)
            { 
               if(index == i)
                {
                    return names[i];
                }
            }
            return "not found";
        }
    }
}
