namespace Praticas.ConcretePrototypes
{
    public class Soldier : ICloneable
    {
        public string Name { get; set; }
        public string Gun { get; set; }
        public Acessory Acessory { get; set; }

        public Soldier() { }

        public Soldier(Soldier soldier)
        {
            Name = soldier.Name;
            Gun = soldier.Gun;
            Acessory = soldier.Acessory;
        }

        //Shallow Copy
        public object Clone() => new Soldier(this); 
        
        //Deep Copy
        public object DeepClone()
        {
            var soldier = (Soldier)this.MemberwiseClone();
            soldier.Acessory = (Acessory)this.Acessory.Clone();
            return soldier;
        }
    }
}
