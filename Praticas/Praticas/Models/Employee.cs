namespace Praticas.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Gratification { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
