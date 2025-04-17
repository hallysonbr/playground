using Praticas.Implementors;
using Praticas.Models;
using System.Xml.Serialization;

namespace Praticas.ConcreteImplementors
{
    public class WriteXml : IGenerateFile
    {
        private readonly string fileName = "employee.xml";
        private readonly XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

        public void WriteFile(Employee employee)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create);

            xmlSerializer.Serialize(fileStream, employee);

            Console.WriteLine($"Arquivo xml {fileName} criado com sucesso.");
        }
    }
}
