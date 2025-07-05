using Praticas.Menu.Abstractions;
using Praticas.Observers;

namespace Praticas.Menu.ConcreteFactories
{
    public class ObserverMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Enviar notificação");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var product = new ConcreteSubject("Iphone 11", 2500, "Esgotado");

                Console.WriteLine($"Produto: {product.Product} - Preço: {product.Price} - Current Status: {product.GetStatus()}");

                var user1 = new ConcreteObserver("Hallyson", product);
                var user2 = new ConcreteObserver("Maria", product);
                var user3 = new ConcreteObserver("José", product);
                var user4 = new ConcreteObserver("Alberto", product);


                Console.WriteLine("Alterando o estado do produto...\n");

                product.SetStatus("Em estoque");

                Console.ReadKey();
            });
        }
    }
}
