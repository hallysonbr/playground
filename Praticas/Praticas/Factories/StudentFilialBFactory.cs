using Praticas.Abstracts;
using Praticas.ConcreteFactories;
using Praticas.Enums;

namespace Praticas.Factories
{
    public class StudentFilialAFactory : StudentFactoryMethod
    {
        public override Student CreateStudent(StudentTypeEnum option) => option switch
        {
            StudentTypeEnum.Graduated => new GraduatedStudentA(),
            StudentTypeEnum.PostGraduated => new PostGraduatedStudentA(),
            _ => throw new NotImplementedException("Valor invalido"),
        };
    }
}
