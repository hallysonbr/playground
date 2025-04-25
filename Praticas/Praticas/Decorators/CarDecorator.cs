using Praticas.Components;

namespace Praticas.Decorators
{
    public class CarDecorator : ICar
    {
        private readonly ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string Optionals() => _car.Optionals();
        
        public virtual decimal Price() => _car.Price();
    }
}
