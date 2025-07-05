using Praticas.Menu.Abstractions;
using Praticas.Visitors;

namespace Praticas.Menu.ConcreteFactories
{
    public class VisitorMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Executar o Padrão visitor");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var motorcycles = new List<Motorcycle>
                {
                    new Motorcycle { Name = "Honda CB 500", Price = 25000, Model = "Honda" },
                    new Motorcycle { Name = "Yamaha MT-03", Price = 30000, Model = "Yamaha" },
                    new Motorcycle { Name = "Kawasaki Ninja 300", Price = 35000, Model = "Kawasaki" }
                };

                var stores = new List<IStore>();

                Console.WriteLine("Exibindo os preços originais das motos\n");

                foreach (var motorcycle in motorcycles)
                {
                    Console.WriteLine($"{motorcycle.Model} {motorcycle.Name}: R${motorcycle.Price}");
                    stores.Add(motorcycle);
                }

                Console.WriteLine("\nAplicando o Padrão Visitor para calcular o preço com desconto\n");

                var priceVisitor = new PriceVisitor();

                foreach (var store in stores)
                    store.Visit(priceVisitor);

                Console.ReadKey();
            });
        }
    }
}
