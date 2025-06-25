using Praticas.Enums;
using Praticas.Factories;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class AbstractFactoryMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das Filais abaixo:");
            Console.WriteLine("1. Filial A");
            Console.WriteLine("2. Filial B");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var typeOption = new Random().Next(0, 2);
                var studentFactoryMethod = StudentSimpleFactory.CreateFactory(Option);
                var student = studentFactoryMethod.CreateStudent((StudentTypeEnum)typeOption);
                Console.WriteLine(student.Assign());
            });
        }
    }
}
