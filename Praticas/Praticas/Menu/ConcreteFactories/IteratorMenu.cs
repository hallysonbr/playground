using Praticas.Iterators;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class IteratorMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Criar Cliente com Iterator");
            Console.WriteLine("9 Sair");

            return ExecuteMenu(() =>
            {
                var collection = new ConcreteCollection();

                collection.Add(new Client(1, "João"));
                collection.Add(new Client(2, "Maria"));
                collection.Add(new Client(3, "José"));

                var iterator = collection.CreateIterator();

                Console.WriteLine("Iterando sobre os clientes:");

                for (var client = iterator.First(); !iterator.IsDone; client = iterator.Next())
                    Console.WriteLine($"Nome: {client.Name}, Id: {client.Id}");

                Console.ReadKey();
            });
        }
    }
}
