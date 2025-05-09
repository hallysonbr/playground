namespace Praticas.Commands
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Waiter
    {
        private readonly Order _order;

        public Waiter(Order order) 
        {
            _order = order;
        }
        public void Execute() => _order.Execute();
    }
}
