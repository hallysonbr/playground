namespace Praticas.Mediators
{
    /// <summary>
    /// Mediator
    /// </summary>
    public interface IMessageGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
