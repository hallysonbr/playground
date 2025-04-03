namespace Praticas.ConcretePrototypes
{
    public class Acessory
    {
        public string Name { get; set; }

        public object Clone() => (Acessory)this.MemberwiseClone();
    }
}