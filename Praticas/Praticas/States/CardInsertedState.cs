namespace Praticas.States
{
    public class CardInsertedState : IAtmMachineState
    {
        public void EjectCard()
        {
            Console.WriteLine("Cartão ejetado com sucesso.");
        }

        public void EnterPin()
        {
            Console.WriteLine("PIN inserido com sucesso.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Não é possível inserir cartão. Um cartão já está inserido.");
        }

        public void RequestCash()
        {
            Console.WriteLine("Dinheiro solicitado com sucesso.");
        }
    }
}
