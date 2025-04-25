namespace Praticas.Subsystems
{
    public class Register
    {
        public void RegisterClient(Client client) => Console.WriteLine($"Registered client: {client.Name}");
    }
}
