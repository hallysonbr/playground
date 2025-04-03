using Praticas.Abstracts;
using Praticas.Enums;
using System.Text;

namespace Praticas.ConcreteFactories
{
    public class PostGraduatedStudentB : Student
    {
        protected override StudentTypeEnum Type => StudentTypeEnum.PostGraduated;
        
        public PostGraduatedStudentB()
        {
            Name = "Tony Stark Student";
            RegisterCode = new Random().Next(1000, 9999).ToString();
        }

        public override string Assign()
        {
            var sb = new StringBuilder();
            sb.Append(base.Assign());
            sb.Append($"Type of Student: {Type}. Enroled on Filial B.");
            return sb.ToString();
        }
    }
}
