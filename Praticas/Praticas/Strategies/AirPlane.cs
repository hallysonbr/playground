namespace Praticas.Strategies
{
    public class AirPlane : ITransportationOption
    {
        public void ChooseTransportation(string passenger)
        {
            Console.WriteLine($"{passenger} escolheu o avião como meio de transporte.");
        }
    }
}
