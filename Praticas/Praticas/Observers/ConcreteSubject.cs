namespace Praticas.Observers
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public string Product { get; private set; }
        public decimal Price {  get; private set; }
        private string Status {  get; set; }

        public ConcreteSubject(string product, decimal price, string status)
        {
            Product = product;
            Price = price;
            Status = status;
        }

        public void SetStatus(string status)
        {
            Console.WriteLine($"Status { Status } changed to {status}");
            Status = status;
            NotifyObservers();
        }

        public string GetStatus()
        {
            return Status;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine($"Notifying observers of {Product} with Price {Price} with status {Status}");
            
            foreach (var observer in _observers)
            {
                observer.Update(Status);
            }
        }
    }
}
