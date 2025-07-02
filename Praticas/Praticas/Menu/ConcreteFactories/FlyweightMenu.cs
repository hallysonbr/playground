using Praticas.Flyweights;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class FlyweightMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Criar circulos de variadas cores.");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var colors = new[] { "Red", "Green", "Blue", "Black", "White" };
                for (int i = 0; i < 10; i++)
                {
                    var circle = (Circle)ShapeFactory.GetShape("circle");
                    circle.SetColor(colors[i % colors.Length]);
                    circle.Draw();
                }
                Console.ReadKey();
            });
        }
    }
}
