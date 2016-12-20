using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectVsSelectMany
{
    public class Student
    {
        public int RollNo;
        public List<string> Subjects;

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(
                new Student { RollNo = 1, Subjects = new List<string> { "c#", "asp.net" } }
                );

            students.Add(
                new Student { RollNo = 2, Subjects = new List<string> { "c#", "ado.net" } }
                );

            students.Add(
                new Student { RollNo = 3, Subjects = new List<string> { "LINQ", "C++" } }
                );

            students.Add(
                new Student { RollNo = 4, Subjects = new List<string> { "JAVA", "JAVASCRIPT" } }
                );

            return students;
        }
    }
}
