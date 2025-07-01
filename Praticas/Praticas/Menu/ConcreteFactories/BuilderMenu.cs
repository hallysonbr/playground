using Praticas.ConcreteBuilders;
using Praticas.Directors;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class BuilderMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Criar Filme");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var cinema = new Cinema(new CinemarkBuilder());
                cinema.InitMovie();
                var cinemarkMovie = cinema.GetMovie();

                cinema = new Cinema(new CinepolisBuilder());
                cinema.InitMovie();
                var cinepolisMovie = cinema.GetMovie();

                Console.WriteLine(cinemarkMovie.ShowMovie());
                Console.WriteLine(cinepolisMovie.ShowMovie());
                Console.ReadKey();
            });
        }
    }
}
