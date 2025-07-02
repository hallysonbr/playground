using Praticas.ConcreteComponents;
using Praticas.ConcreteDecorators;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class DecoratorMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Criar Carro");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var car = new Car();
                Console.WriteLine("Criando um carro versão básica");
                Console.WriteLine($"Preço do carro: {car.Price()}");
                Console.WriteLine($"Opcionais do carro: {car.Optionals()}");

                Console.WriteLine("-----Aplicando o Padrão Decorator-----");

                var car2 = new Car();
                var confortCar = new ConfortCarDecorator(car2);

                Console.WriteLine("Adicionando o pacote confort");
                Console.WriteLine($"Preço do carro: {confortCar.Price()}");
                Console.WriteLine($"Opcionais do carro: {confortCar.Optionals()}");

                var sportCar = new SportCarDecorator(confortCar);
                Console.WriteLine("Adicionando o pacote sport");
                Console.WriteLine($"Preço do carro: {sportCar.Price()}");
                Console.WriteLine($"Opcionais do carro: {sportCar.Optionals()}");

                Console.ReadKey();
            });
        }
    }
}
