// See https://aka.ms/new-console-template for more information
using Praticas.Menu.Factories;
using Praticas.Menu.Interfaces;

while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Escolha um dos Design Patterns abaixo:");
        Console.WriteLine("1. Simple Factory");
        Console.WriteLine("2. Abstract Factory");
        Console.WriteLine("3. Builder");
        Console.WriteLine("4. Prototype");
        Console.WriteLine("5. Singleton");
        Console.WriteLine("6. Adapter");
        Console.WriteLine("7. Bridge");
        Console.WriteLine("8. Composite");
        Console.WriteLine("9. Decorator");
        Console.WriteLine("10. Facade");
        Console.WriteLine("11. Flyweight");
        Console.WriteLine("12. Proxy");
        Console.WriteLine("13. Chain Of Responsibility");
        Console.WriteLine("14. Command");
        Console.WriteLine("15. Interpreter");
        Console.WriteLine("16. Iterator");
        Console.WriteLine("17. Mediator");
        Console.WriteLine("18. Memento");
        Console.WriteLine("19. Observer");
        Console.WriteLine("20. State");
        Console.WriteLine("21. Strategy");
        Console.WriteLine("22. Template Method");
        Console.WriteLine("23. Visitor");

        string input = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrEmpty(input) && input.Length <= 2)
        {
            var exit = true;
            do
            {
                IMenu item = MenuFactory.GetMenu(input.Trim());
                exit = item.ShowMenu();
            }
            while (!exit);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        Console.ReadKey();
    }
}