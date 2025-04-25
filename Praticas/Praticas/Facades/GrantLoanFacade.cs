using Praticas.Subsystems;

namespace Praticas.Facades
{
    public class GrantLoanFacade
    {
        private CreditLimit creditLimit;
        private Serasa serasa;
        private Cadin cadin;
        private Register register;

        public GrantLoanFacade()
        {
            creditLimit = new CreditLimit();
            serasa = new Serasa();
            cadin = new Cadin();
            register = new Register();
        }

        public bool GrantLoan(Client client, double value)
        {
            Console.WriteLine("Verificando limite de credito");

            register.RegisterClient(client);

            var result = true;

            if (serasa.IsInSerasa(client))
            {
                Console.WriteLine($"Client {client.Name} has SERASA restrictions");
                result = false;
            }

            if (cadin.IsInCadin(client))
            {
                Console.WriteLine($"Client {client.Name} has CADIN restrictions");
                result = false;
            }

            if (!creditLimit.HasCreditLimit(client, value))
            {
                Console.WriteLine($"Client {client.Name} has no credit limit. Credit limit is lower than {value}");
                result = false;
            }

            return result; 
        }
    }
}
