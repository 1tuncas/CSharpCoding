using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "K";
            course1.watchRatio = 32;

            Course course2 = new Course();
            course2.CourseName = "K";
            course2.watchRatio = 32;


            Course[] courses = new Course[] { course1, course2 };

            foreach (Course course in courses)
            {
                Console.WriteLine("Course Name: " + course.CourseName);
            }


        
        }
 }

        class Course
        {

    public string CourseName { get; set; }
    public string educator { get; set; }
    public int watchRatio { get; set; }

        public int MyProperty { get; set; }
    }
}
