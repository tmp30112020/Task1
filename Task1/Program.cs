using IndepententFilesReader;
using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProcessor<Student> students = new FileProcessor<Student>(@"Files\Students.txt", "|");
            students.ProcessFile();

            FileProcessor<Person> persons = new FileProcessor<Person>(@"Files\Persons.txt", "|");
            persons.ProcessFile();

            var fromStudents = students.LineObjects.Select(x => x).Where(x => x.Degree.IndexOf("master", StringComparison.OrdinalIgnoreCase) >= 0).OrderBy(y => y.Semesters);
            fromStudents.Print();

            var fromPersons = persons.LineObjects.Select(x => x).Where(y => y.Gender.IndexOf("fem", StringComparison.OrdinalIgnoreCase) >= 0 && y.Age > 30).OrderByDescending(x => x.Age);
            fromPersons.Print();
        }
    }
}
