namespace Praticas.Visitors
{
    /// <summary>
    /// Concrete Element
    /// </summary>
    public class Motorcycle : IStore
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}