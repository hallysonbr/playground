namespace Praticas.Subsystems
{
    public class Serasa
    {
        public bool IsInSerasa(Client client)
        {
            Console.WriteLine($"Checking if {client.Name} is in SERASA");
            return true;
        }
    }
}
