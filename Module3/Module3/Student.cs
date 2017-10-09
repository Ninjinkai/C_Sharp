using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Student
    {
        /// <summary>
        /// The student's first name.
        /// </summary>
        internal string firstName;
        /// <summary>
        /// The student's last name.
        /// </summary>
        internal string lastName;
        /// <summary>
        /// The student's birthday.
        /// </summary>
        internal DateTime birthday;
        /// <summary>
        /// The student's major.
        /// </summary>
        internal string major;

        /// <summary>
        /// Has the user enter the student's information
        /// </summary>
        internal void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday: ");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's major: ");
            major = Console.ReadLine();
        }

        /// <summary>
        /// Prints information about the student.
        /// </summary>
        internal void PrintStudentDetails()
        {
            Console.WriteLine($"{firstName} {lastName} was born on {birthday.ToString("MMMM dd, yyyy")} and is working towards a degree in {major}.");
        }
    }
}
