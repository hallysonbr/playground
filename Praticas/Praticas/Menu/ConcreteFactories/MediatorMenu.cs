using Praticas.Mediators;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class MediatorMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Iniciar conversas no grupo");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var group = new ConcreteMessageGroupMediator();

                var user1 = new ConcreteUser(group, "João");
                var user2 = new ConcreteUser(group, "Maria");
                var user3 = new ConcreteUser(group, "José");

                group.RegisterUser(user1);
                group.RegisterUser(user2);
                group.RegisterUser(user3);

                user1.Send("Olá, pessoal!");
                user2.Send("Oi, João!");
                user3.Send("Oi, Maria!");

                Console.ReadKey();
            });
        }
    }
}
