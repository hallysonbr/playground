using Praticas.Implementors;
using Praticas.Models;
using System.Text.Json;

namespace Praticas.ConcreteImplementors
{
    public class WriteJson : IGenerateFile
    {
        private readonly string fileName = "employee.json";

        public void WriteFile(Employee employee)
        {
            var serializedJson = JsonSerializer.Serialize(employee);

            File.WriteAllText(fileName, serializedJson);

            Console.WriteLine($"Arquivo json {fileName} criado com sucesso.");
        }
    }
}
