namespace Praticas.Iterators
{
    /// <summary>
    /// Concrete Collection
    /// </summary>
    public class ConcreteCollection : IAbstractCollection
    {
        private readonly List<Client> _clients = new List<Client>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public Client GetClient(int index)
        {
            return _clients[index];
        }

        public int Count => _clients.Count;

        public void Add(Client client)
        {
            _clients.Add(client);
        }

        public void Remove(Client client)
        {
            _clients.Remove(client);
        }
    }
}
