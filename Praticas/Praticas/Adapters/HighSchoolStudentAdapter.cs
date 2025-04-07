using Praticas.Adaptees;
using Praticas.Models;
using Praticas.Targets;

namespace Praticas.Adapters
{
    public class HighSchoolStudentAdapter : IHighSchoolStudentTarget
    {
        private MonthlyFeeProcessor _monthlyFeeProcessor = new();

        public void ProcessMonthlyFee(string[,] students)
        {
            var highSchoolStudents = new List<HighSchoolStudent>();

            for (int i = 0; i < students.GetLength(0); i++)
            {
                var id = Guid.Parse(students[i, 0]);
                var name = students[i, 1];
                var course = students[i, 2];
                var monthlyFee = decimal.Parse(students[i, 3]);

                var student = new HighSchoolStudent(id, name, course, monthlyFee);
                highSchoolStudents.Add(student);
            }

            Console.WriteLine("Students Converted from array to list");

            _monthlyFeeProcessor.Process(highSchoolStudents);
        }
    }
}
