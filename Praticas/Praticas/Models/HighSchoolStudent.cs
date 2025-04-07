namespace Praticas.Models
{
    public class HighSchoolStudent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public decimal MonthlyFee { get; set; }

        public HighSchoolStudent(Guid id, string name, string course, decimal monthlyFee)
        {
            Id = id;
            Name = name;
            Course = course;
            MonthlyFee = monthlyFee;
        }
    }
}
