using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class SingletonMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine("Criando uma instância do Singleton...");
                var instance1 = Singleton.Singleton.Instance;

                Console.WriteLine("Criando uma segunda instância do Singleton...");
                var instance2 = Singleton.Singleton.Instance;

                if (instance1 == instance2) Console.WriteLine("Instancias iguais!");
                else Console.WriteLine("Instancias diferentes!");


                Console.WriteLine("Criando uma instância do Singleton Thread Safe...");
                Parallel.Invoke
                (
                    () => { Console.WriteLine($"Thread 1: {Singleton.Singleton.InstanceTheadSafe.GetHashCode()}"); },
                    () => { Console.WriteLine($"Thread 2: {Singleton.Singleton.InstanceTheadSafe.GetHashCode()}"); }
                );

                Console.ReadKey();
            });
        }
    }
}
