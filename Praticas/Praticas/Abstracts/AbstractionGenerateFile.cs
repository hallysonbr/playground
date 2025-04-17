using Praticas.Implementors;
using Praticas.Models;

namespace Praticas.Abstracts
{
    public abstract class AbstractionGenerateFile
    {
        protected IGenerateFile _generateFile;

        protected AbstractionGenerateFile(IGenerateFile generateFile)
        {
            _generateFile = generateFile;
        }

        public virtual void WriteFile(Employee employee)
        {
            _generateFile.WriteFile(employee);
        }
    }
}
