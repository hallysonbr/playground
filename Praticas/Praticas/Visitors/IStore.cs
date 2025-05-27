namespace Praticas.Visitors
{
    /// <summary>
    /// Element
    /// </summary>
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
}
