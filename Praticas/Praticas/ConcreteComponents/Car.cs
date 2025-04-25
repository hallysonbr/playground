using Praticas.Components;

namespace Praticas.ConcreteComponents
{
    public class Car : ICar
    {
        public string Optionals() => "Car optionals: Air conditioning, GPS, Sunroof, Leather seats";

        public decimal Price() => 100000.00M;
    }
}
