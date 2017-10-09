using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Teacher
    {
        /// <summary>
        /// The teacher's first name.
        /// </summary>
        internal string firstName;
        /// <summary>
        /// The teacher's last name.
        /// </summary>
        internal string lastName;
        /// <summary>
        /// The subject taught by this teacher.
        /// </summary>
        internal string subject;
        /// <summary>
        /// The number of classes taught this semester.
        /// </summary>
        internal int numberOfClassesTaughtThisSemester;

        /// <summary>
        /// Get the teacher's information from the user.
        /// </summary>
        internal void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the subject taught: ");
            subject = Console.ReadLine();
            Console.WriteLine("Enter the numebr of classes for this teacher this semester: ");
            int.TryParse(Console.ReadLine(), out numberOfClassesTaughtThisSemester);
        }

        /// <summary>
        /// Prints the teacher's information
        /// </summary>
        internal void PrintTeacherInformation()
        {
            Console.WriteLine($"{firstName} {lastName} teaches {subject} and has {numberOfClassesTaughtThisSemester.ToString()} classes this semester.");
        }
    }
}
