using Praticas.Handlers;

namespace Praticas.ConcreteHandlers
{
    public class TeamSupervisor : AuthorizerHandler
    {
        private const int MAX_DAYS = 15;
        public override void Handle(string name, int days)
        {
            if (days > MAX_DAYS)
                _authorizer?.Handle(name, days);
            else
                Console.WriteLine($"Team supervisor approved {days} day off days for {name}");
        }
    }
}
