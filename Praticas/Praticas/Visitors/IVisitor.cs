namespace Praticas.Visitors
{
    /// <summary>
    /// Visitor
    /// </summary>
    public interface IVisitor
    {
        void Accept(Motorcycle motorcycle);
    }
}
