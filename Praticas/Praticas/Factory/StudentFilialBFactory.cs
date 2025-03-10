using Praticas.Abstracts;
using Praticas.Concretes;
using Praticas.Enums;

namespace Praticas.Factory
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
