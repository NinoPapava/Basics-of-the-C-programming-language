using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Static_Part3
{
    public class StudentFourCourse
    {
        public string name;
        public string lastname;

        public static int course;
    }

    public static class Infinity 
        {
        public static string Engine;
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            StudentFourCourse.course = 5;


            StudentFourCourse student = new StudentFourCourse();
            student.name = "nino";
            student.lastname = "papava";
           // student.course = 5;

            StudentFourCourse student1 = new StudentFourCourse();
            student1.name = "giorgi";
            student1.lastname = "papava";
            //student1.course = 5;

            StudentFourCourse student2 = new StudentFourCourse();
            student2.name = "tatia";
            student2.lastname = "papava";
            //student2.course = 2;

            StudentFourCourse[] studentCourses = new StudentFourCourse[] 
            { student, student1, student2 };

            foreach (var StudentInfo in studentCourses)
            {
                Console.WriteLine(StudentInfo.name);
                Console.WriteLine(StudentInfo.lastname);
                Console.WriteLine(StudentFourCourse.course);
            }

            //Using a static class
            Infinity.Engine = "3.8";
            Console.WriteLine(Infinity.Engine);
        }
    }
}
