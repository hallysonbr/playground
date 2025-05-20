namespace Praticas.Iterators
{
    /// <summary>
    /// Iterator
    /// </summary>
    public interface IAbstractIterator
    {
        Client First();
        Client Next();
        bool IsDone { get; }
    }
}
