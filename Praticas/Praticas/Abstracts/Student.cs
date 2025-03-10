using Praticas.Enums;

namespace Praticas.Abstracts
{
    public abstract class Student
    {
        protected string Name { get; set; } = string.Empty;
        protected string RegisterCode { get; set; } = string.Empty;
        protected abstract StudentTypeEnum Type { get; }


        public virtual string Assign() => $"Student {Name} - {RegisterCode} has been assigned.";
    }
}
