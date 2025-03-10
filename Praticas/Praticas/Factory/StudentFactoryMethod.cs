using Praticas.Abstracts;
using Praticas.Enums;

namespace Praticas.Factory
{
    public abstract class StudentFactoryMethod
    {
        public abstract Student CreateStudent(StudentTypeEnum option);
    }
}
