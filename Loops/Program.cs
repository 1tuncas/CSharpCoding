using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string course1 = "A";
            string course2 = "B";

            string[] courses = new string[] {"A","B","C" }; 
            

            for (int i = 0; i <=courses.Length; i++)
            {

                Console.WriteLine(courses[i]);


            }
            Console.WriteLine("******************");

   

            foreach (string course in courses)
            {
                Console.WriteLine(course);

            }


           



        }
    }
}
