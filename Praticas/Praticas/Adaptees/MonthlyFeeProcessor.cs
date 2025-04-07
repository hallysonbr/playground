using Praticas.Models;

namespace Praticas.Adaptees
{
    public class MonthlyFeeProcessor
    {
        public void Process(List<HighSchoolStudent> students)
        {
            foreach (var student in students)
                Console.WriteLine($"Processando mensalidade do aluno {student.Name} do curso {student.Course} com valor {student.MonthlyFee}");
            
        }
    }
}
