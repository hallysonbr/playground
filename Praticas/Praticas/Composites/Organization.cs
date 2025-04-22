using Praticas.Components;

namespace Praticas.Composites
{
    public class Organization : WorkingHours
    {
        protected List<WorkingHours> departments = new List<WorkingHours>();

        public override void Add(WorkingHours component)
        {
            departments.Add(component);
        }

        public override void Remove(WorkingHours component)
        {
            departments.Remove(component);
        }

        public override int GetWorkingHours()
        {
            var totalHours = 0;
            foreach (var department in departments)
            {
                totalHours += department.GetWorkingHours();
            }
            
            Console.WriteLine($"{Name} registered {totalHours} hours in total.");
            return totalHours;
        }
    }
}
