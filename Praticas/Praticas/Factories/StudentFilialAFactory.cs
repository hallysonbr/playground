using Praticas.Abstracts;
using Praticas.ConcreteFactories;
using Praticas.Enums;

namespace Praticas.Factories
{
    public class StudentFilialBFactory : StudentFactoryMethod
    {
        public override Student CreateStudent(StudentTypeEnum option) => option switch
        {
            StudentTypeEnum.Graduated => new GraduatedStudentB(),
            StudentTypeEnum.PostGraduated => new PostGraduatedStudentB(),
            _ => throw new NotImplementedException("Valor invalido"),
        };
}
}
