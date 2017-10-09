using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Course
    {
        /// <summary>
        /// The course's title
        /// </summary>
        internal string title;
        /// <summary>
        /// The number of students enrolled in the course.
        /// </summary>
        internal int numberOfStudentsEnrolled;
        /// <summary>
        /// The name of the course's teacher.
        /// </summary>
        internal string teacher;
        /// <summary>
        /// The names of students taking the course.
        /// </summary>
        internal List<string> students;

        /// <summary>
        /// Gets the information for the course from the user.
        /// </summary>
        internal void GetCourseInformation()
        {

            Console.WriteLine("Enter the course's title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter the numebr of students in this class: ");
            int.TryParse(Console.ReadLine(), out numberOfStudentsEnrolled);
            Console.WriteLine("Enter the course teacher's name: ");
            teacher = Console.ReadLine();
        }

        /// <summary>
        /// Prints the course information
        /// </summary>
        internal void PrintCourseInformation()
        {
            Console.WriteLine($"{title} is being taught by {teacher} and has {numberOfStudentsEnrolled.ToString()} students enrolled.");
        }
    }
}
