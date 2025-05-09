using Praticas.Handlers;

namespace Praticas.ConcreteHandlers
{
    public class HRDepartment : AuthorizerHandler
    {
        private const int MAX_DAYS = 30;
        public override void Handle(string name, int days)
        {
            if (days > MAX_DAYS)
                Console.WriteLine($"Request of {days} days denied for {name}. Please contact Directory Department.");
            else
                Console.WriteLine($"HR department approved {days} day off days for {name}");
        }
    }
}
