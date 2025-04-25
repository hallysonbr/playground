using Praticas.Components;
using Praticas.Decorators;

namespace Praticas.ConcreteDecorators
{
    public class ConfortCarDecorator : CarDecorator
    {
        public ConfortCarDecorator(ICar car) : base(car)
        {
        }

        public override decimal Price()
        {
            var price = base.Price();
            price+= 15000;
            return price;
        }

        public override string Optionals()
        {
            var optionals = base.Optionals();
            optionals += ", Bluetooth, GPS, Cruise Control, Automatic Pilot";
            return optionals;
        }
    }
}
