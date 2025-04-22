using Praticas.Components;

namespace Praticas.Leafs
{
    public class WorkingEmployee : WorkingHours
    {
        public Guid Id { get; set; }
        public int Hours { get; set; }

        public override int GetWorkingHours()
        {
            Console.WriteLine($"Employee {Id} - {Name} registered {Hours} working hours.");
            return Hours;
        }
    }
}
