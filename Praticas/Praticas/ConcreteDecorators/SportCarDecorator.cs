using Praticas.Components;
using Praticas.Decorators;

namespace Praticas.ConcreteDecorators
{
    public class SportCarDecorator : CarDecorator
    {
        public SportCarDecorator(ICar car) : base(car)
        {
        }

        public override decimal Price()
        {
            var price = base.Price();
            price+= 10000;
            return price;
        }

        public override string Optionals()
        {
            var optionals = base.Optionals();
            optionals += ", Turbo Engine, Sport Seats, Sport Painting, Traction Control";
            return optionals;
        }
    }
}
