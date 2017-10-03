using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName = "Jane";
            string studentLastName = "Smith";
            DateTime studentBirthdate = new DateTime(2000, 1, 1);
            string studentAddressLine1 = "123 Fake St.";
            string studentAddressLine2 = "Apt 13";
            string studentCity = "Springfield";
            string studentStateProvince = "MO";
            string studentZipPostal = "55555";
            string studentCountry = "USA";

            string teacherFirstName = "Sally";
            string teacherLastName = "Jones";
            DateTime teacherBirthdate = new DateTime(1980, 1, 1);
            string teacherAddressLine1 = "6789 Amazing Pl.";
            string teacherAddressLine2 = "";
            string teacherCity = "Springfield";
            string teacherStateProvince = "MO";
            string teacherZipPostal = "55555";
            string teacherCountry = "USA";

            string uProgramName = "Math";
            string uProgramDepartmentHead = "Allison Langley";
            int uProgramDegrees = 7;

            string degreeName = "Bachelor of Science";
            int degreeCreditsRequired = 120;

            string courseName = "Number Theory";
            int courseCredits = 3;
            int courseDurationInWeeks = 16;
            string courseTeacher = "John Nash";

            Console.WriteLine("{0} {1} is taking {2} this semester.  The course is taught by {3} and is worth {4} credits.", studentFirstName, studentLastName, courseName, courseTeacher, courseCredits);
            Console.WriteLine("The {0} program is headed by {1}.  It offers {2} tracks that award {3} degrees after {4} credits have been earned.", uProgramName, uProgramDepartmentHead, uProgramDegrees, degreeName, degreeCreditsRequired);
        }
    }
}
