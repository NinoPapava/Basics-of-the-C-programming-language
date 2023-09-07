using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Part2
{

    class Student
    {

        public string firstName;
        public string lastName;
        public int age;
        public int points;
        public string id;

        //Constructor
        public Student(string firstName, string lastName, int age, int points, string id) 
        {
           this.firstName = firstName;
           this.lastName = lastName;
           this.age = age;
           this.points = points;   
           this.id = id;
        }
        public Student()
        {
        
        }

    }

    internal class Program
    {

       

        static void Main(string[] args)
        {
            //class, constructors
            Student student1 = new Student
            (
                "nino",
                "papava",
                26,
                100,
                "59112244400"
            );

            Student student2 = new Student();

            student2.firstName = "nino";
            student2.lastName = "papava";
            student2.age = 26;
            student2.points = 100;
            student2.id = "59001144888";

            Console.WriteLine(student1.firstName);
            Console.WriteLine(student2.lastName);


            //arrays
            Student[] students = new Student[]
            {
                new Student("nino", "papava", 25, 100, "453"),
                new Student("ani", "bitsadze", 22, 85, "537"),
                new Student("tatia", "papava", 28, 78, "887"),
                new Student("linda", "topuria", 24, 100, "856"),
                new Student("tatia", "papava", 29, 100, "459")
            };

            string fullName = Top1(students);
            Console.WriteLine(fullName);
            
        }

        //function
        static public string Top1(Student[] students)
        {
            int numb = 0;
            foreach (var student in students)
            {
                if (student.points > numb)
                {
                    numb = student.points;
                }
            }
            foreach (var student in students)
            {
                if (student.points == numb)
                {
                    return $"{student.firstName} {student.lastName}";
                }
            }


            return null;
        }
    }
}
