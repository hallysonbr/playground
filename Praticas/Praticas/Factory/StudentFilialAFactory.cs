using Praticas.Abstracts;
using Praticas.Concretes;
using Praticas.Enums;

namespace Praticas.Factory
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
