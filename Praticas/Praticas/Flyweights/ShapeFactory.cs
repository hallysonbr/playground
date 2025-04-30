namespace Praticas.Flyweights
{
    /// <summary>
    /// The 'Flyweight Factory' class
    /// </summary>
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public static IShape GetShape(string key)
        {
            if (key != "circle") throw new ArgumentException("Invalid shape.");

            if (!shapes.ContainsKey(key))
            {
                Console.WriteLine($"Creating {key}.");
                shapes.Add(key, new Circle());
            }
            return shapes[key];
        }
    }
}
