using Praticas.Menu.Abstractions;
using Praticas.Proxies;

namespace Praticas.Menu.ConcreteFactories
{
    public class ProxyMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Acessar pasta compartilhada.");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine("Acessando pasta compartilhada...");

                Console.WriteLine("Perfil Desenvolvedor tentanto acessar a pasta...");
                var user1 = new User("João", "123456", "desenvolvedor");
                var sharedFolder1 = new SharedFolderProxy(user1);
                sharedFolder1.ReadAndWrite();

                Console.WriteLine("Perfil Visitante tentanto acessar a pasta...");
                var user2 = new User("Maria", "654321", "visitante");
                var sharedFolder2 = new SharedFolderProxy(user2);
                sharedFolder2.ReadAndWrite();

                Console.WriteLine("Perfil Administrador tentanto acessar a pasta...");
                var user3 = new User("José", "789456", "admin");
                var sharedFolder3 = new SharedFolderProxy(user3);
                sharedFolder3.ReadAndWrite();

                Console.ReadKey();
            });
        }
    }
}
