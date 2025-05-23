namespace Praticas.Strategies
{
    public class Cab : ITransportationOption
    {
        public void ChooseTransportation(string passenger)
        {
            Console.WriteLine($"{passenger} escolheu o táxi como meio de transporte.");
        }
    }
}
