using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Part1
{
    public class Person
    {
        public string name;
        public int age;
        public string idNumber;

        public void Print()
        {
            Console.WriteLine($"name:{name} age:{age} id:{idNumber}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.name = "nino";
            person1.age = 22;
            person1.idNumber = "5945344565";

            person1.Print();
            

            Person person2 = new Person();
            person2.name = "gvantsa";
            person2.age = 26;
            person2.idNumber = "4845342222";

            person2.Print();

        }
    }
}
