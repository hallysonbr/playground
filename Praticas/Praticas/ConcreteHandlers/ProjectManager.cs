using Praticas.Handlers;

namespace Praticas.ConcreteHandlers
{
    public class ProjectManager : AuthorizerHandler
    {
        private const int MAX_DAYS = 5;

        public override void Handle(string name, int days)
        {
            if (days > MAX_DAYS)
                _authorizer?.Handle(name, days);
            else
                Console.WriteLine($"Project manager approved {days} day off days for {name}");
        }
    }
}
