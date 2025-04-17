using Praticas.Abstracts;
using Praticas.Implementors;
using Praticas.Models;

namespace Praticas.RefinedAbstractions
{
    public class CalculateSalary : AbstractionGenerateFile
    {
        public CalculateSalary(IGenerateFile generateFile) : base(generateFile) {}

        public void ProcessSalary(Employee employee)
        {
            employee.TotalSalary = employee.BaseSalary + employee.Gratification;

            Console.WriteLine($"Salário total: {employee.TotalSalary}");

            _generateFile.WriteFile(employee);
        }
    }
}
