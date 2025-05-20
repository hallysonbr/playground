namespace Praticas.Iterators
{
    /// <summary>
    /// Concrete Iterator
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        private readonly ConcreteCollection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public Client First()
        {
            _current = 0;
            return _collection.GetClient(_current);
        }

        public Client Next()
        {
            _current += _step;

            if(!IsDone)
                return _collection.GetClient(_current);
            else
                return null;
        }

        public bool IsDone => _current >= _collection.Count;
    }
}