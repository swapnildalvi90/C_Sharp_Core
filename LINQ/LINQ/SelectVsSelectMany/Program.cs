/* in select u need to use 2 for loops as u get collection of collection
 in slectmany you need to use only 1 for loop as you get only one flat collection
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectVsSelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new Student().GetAllStudents();

            IEnumerable<string> subjects = students.SelectMany(s => s.Subjects);

            IEnumerable<string> subjectsThroughSql = (from student in students
                                         from subject in student.Subjects
                                                     select subject).Distinct();

            foreach (string subFromSql in subjectsThroughSql)
            {
                Console.WriteLine(subFromSql);
            }
            Console.WriteLine("__________________________________");

            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }


            Console.WriteLine("__________________________________");

            IEnumerable<List<string>> CollectionOfSubjectCollection = students.Select(s => s.Subjects);

            foreach (var subs in CollectionOfSubjectCollection)
            {
                foreach(var subject in subs)
                Console.WriteLine(subject);
            }

            Console.ReadKey();

        }
    }
}
