namespace Praticas.Subsystems
{
    public class CreditLimit
    {
        private const double limit = 200000.00;
        public bool HasCreditLimit(Client client, double value)
        {
            Console.WriteLine($"Checking if {client.Name} has credit limit of {value}.");
            
            if(value > limit)
                return false;
            else
                return true;
        }
    }
}
