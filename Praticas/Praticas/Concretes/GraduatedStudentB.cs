using Praticas.Abstracts;
using Praticas.Enums;
using System.Text;

namespace Praticas.Concretes
{
    public class GraduatedStudentB : Student
    {
        protected override StudentTypeEnum Type => StudentTypeEnum.Graduated;
        
        public GraduatedStudentB()
        {
            Name = "Bruce Wayne Student";
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
