namespace Praticas.Observers
{
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private ISubject _subject;

        public ConcreteObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;

            _subject.RegisterObserver(this);
        }

        public void Update(string status)
        {
            Console.WriteLine($"Observer {_name} received update: {status}");
        }
    }
}
