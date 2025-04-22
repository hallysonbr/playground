namespace Praticas.Components
{
    public abstract class WorkingHours
    {
        public WorkingHours() { }

        public string Name { get; set; }

        public abstract int GetWorkingHours();

        public virtual void Add(WorkingHours component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(WorkingHours component)
        {
            throw new NotImplementedException();
        }
    }
}
