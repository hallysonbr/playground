namespace Praticas.Mediators
{
    /// <summary>
    /// Colleage
    /// </summary>
    public abstract class User
    {
        protected ConcreteMessageGroupMediator _mediator;
        protected string _name;

        protected User(ConcreteMessageGroupMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}