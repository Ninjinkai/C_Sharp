using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class SelfAssessment
    {
        internal static void RunStudent()
        {
            Student student = new Student();
            student.GetStudentInformation();
            student.PrintStudentDetails();
        }

        internal static void RunTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.GetTeacherInformation();
            teacher.PrintTeacherInformation();
        }

        internal static void RunCourse()
        {
            Course course = new Course();
            course.GetCourseInformation();
            course.PrintCourseInformation();
        }

    }
}
