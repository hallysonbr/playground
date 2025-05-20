namespace Praticas.Mediators
{
    public class ConcreteUser : User
    {
        public ConcreteUser(ConcreteMessageGroupMediator mediator, string name) 
            : base(mediator, name) {}

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} send: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} received: {message}");
        }
    }
}
