namespace Praticas.Visitors
{
    /// <summary>
    /// Concrete visitor
    /// </summary>
    public class PriceVisitor : IVisitor
    {
        private const int DISCOUNT = 12;

        public void Accept(Motorcycle motorcycle)
        {
            var discountedPrice = motorcycle.Price - ((motorcycle.Price / 100) * DISCOUNT);

            Console.WriteLine($"{motorcycle.Model} {motorcycle.Name}: R${ discountedPrice }");
        }
    }
}
