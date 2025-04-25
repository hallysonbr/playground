namespace Praticas.Subsystems
{
    public class Cadin
    {
        public bool IsInCadin(Client client)
        {
            Console.WriteLine($"Checking if {client.Name} is in CADIN");
            return true;
        }
    }
}
