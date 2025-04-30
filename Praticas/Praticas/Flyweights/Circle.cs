namespace Praticas.Flyweights
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Intrinsic state
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Extrinsic state
        /// </summary>
        public int X { get; set; } = 10;
        public int Y { get; set; } = 20;
        public int Radius { get; set; } = 30;

        public void Draw()
        {
           Console.WriteLine($"Drawing Circle[color: {Color}, x: {X}, y: {Y}, radius: {Radius}]");
        }

        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
