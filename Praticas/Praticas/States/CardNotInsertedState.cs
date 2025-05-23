namespace Praticas.States
{
    public class CardNotInsertedState : IAtmMachineState
    {
        public void EjectCard()
        {
            Console.WriteLine("Não é possível ejetar cartão. Nenhum cartão inserido.");
        }

        public void EnterPin()
        {
            Console.WriteLine("Não é possível inserir PIN. Nenhum cartão inserido.");
        }

        public void InsertCard()
        {
           Console.WriteLine("Cartão inserido com sucesso.");
        }

        public void RequestCash()
        {
            Console.WriteLine("Não é possível solicitar dinheiro. Nenhum cartão inserido.");
        }
    }
}
