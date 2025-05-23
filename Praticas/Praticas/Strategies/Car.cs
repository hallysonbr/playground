namespace Praticas.Strategies
{
    public class Car : ITransportationOption
    {
        public void ChooseTransportation(string passenger)
        {
            Console.WriteLine($"{passenger} escolheu o carro como meio de transporte.");
        }
    }
}
