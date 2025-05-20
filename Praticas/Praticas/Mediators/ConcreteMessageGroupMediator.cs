namespace Praticas.Mediators
{
    /// <summary>
    /// Concrete Mediator
    /// </summary>
    public class ConcreteMessageGroupMediator : IMessageGroupMediator
    {
        private readonly List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user) u.Receive(message);
            }
        }
    }
}
