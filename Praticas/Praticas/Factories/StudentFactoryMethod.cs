using Praticas.Abstracts;
using Praticas.Enums;

namespace Praticas.Factories
{
    public abstract class StudentFactoryMethod
    {
        public abstract Student CreateStudent(StudentTypeEnum option);
    }
}
