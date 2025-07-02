// See https://aka.ms/new-console-template for more information
using Praticas.Interpreters.AbstractExpressions;
using Praticas.Interpreters.ConcreteExpressions;
using Praticas.Interpreters.Contexts;
using Praticas.Iterators;
using Praticas.Mediators;
using Praticas.Mementos;
using Praticas.Menu.Factories;
using Praticas.Menu.Interfaces;
using Praticas.Observers;
using Praticas.States;
using Praticas.Strategies;
using Praticas.TemplateMethods;
using Praticas.Visitors;

int value;
char option;

while (true)
{
    //MenuCalculator();
    //MenuNotification();
    //MenuAtmMachine();
    //MenuTransportation();
    //MenuVideoPlayer();
    //MenuStore();


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

        //CalculatorMemento();
        //NotificationObserver();
        //AtmMachineState();
        //TransportationStrategy();
        //VideoPlayerTemplateMethod();
        //StoreVisitor();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        Console.ReadKey();
    }
}

void MenuCalculator()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Calcular a soma de dois números e armazenar o estado");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void CalculatorMemento()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        Console.WriteLine("Calculando a soma de dois números e armazenando o estado...");

        var calculator = new Calculator();
        calculator.SetFirstNumber(10);
        calculator.SetSecondNumber(20);

        Console.WriteLine($"Estado 1: {calculator.GetCalculationResult()}");

        var memento = calculator.BackupLastCalculation();

        Console.WriteLine("Calculando a soma de dois números e armazenando o estado...");

        calculator.SetFirstNumber(30);
        calculator.SetSecondNumber(40);

        Console.WriteLine($"Estado 2: {calculator.GetCalculationResult()}");

        Console.WriteLine("Restaurando o estado anterior...");

        calculator.RestoreLastCalculation(memento);

        Console.WriteLine($"Estado restaurado: {calculator.GetCalculationResult()}");
        Console.ReadKey();
    }
}

void MenuNotification()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Enviar notificação");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void NotificationObserver()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var product = new ConcreteSubject("Iphone 11", 2500, "Esgotado");

        Console.WriteLine($"Produto: {product.Product} - Preço: {product.Price} - Current Status: { product.GetStatus() }");

        var user1 = new ConcreteObserver("Hallyson", product);
        var user2 = new ConcreteObserver("Maria", product);
        var user3 = new ConcreteObserver("José", product);
        var user4 = new ConcreteObserver("Alberto", product);


        Console.WriteLine("Alterando o estado do produto...\n");

        product.SetStatus("Em estoque"); 

        Console.ReadKey();
    }
}

void MenuAtmMachine()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Iniciar caixa eletrônico");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void AtmMachineState()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var atmMachine = new AtmMachine();

        Console.WriteLine($"Iniciando caixa eletrônico. Estado atual: { atmMachine.GetCurrentState().GetType().Name }");

        atmMachine.EnterPin();
        atmMachine.RequestCash();
        atmMachine.EjectCard();
        atmMachine.InsertCard();

        Console.WriteLine();

        atmMachine.EnterPin();
        atmMachine.RequestCash();
        atmMachine.InsertCard();
        atmMachine.EjectCard();

        Console.ReadKey();
    }
}

void MenuTransportation()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções para sua viagem:");
    Console.WriteLine("1. Carro Particular");
    Console.WriteLine("2. Táxi");
    Console.WriteLine("3. Avião");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void TransportationStrategy()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1' && option != '2' && option != '3') return;

        var context = new TrasnportationOptionContext();
        context.DefineStrategy(option);
        context.ChooseTransportation("João");
        Console.ReadKey();
    }
}

void MenuVideoPlayer()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Executar Template Method");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void VideoPlayerTemplateMethod()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        Console.WriteLine("-----Video Player - Video MP4 ---------");

        VideoPlayer videoPlayer = new Mp4Video();

        videoPlayer.PlayVideo();

        Console.WriteLine("\n");

        Console.WriteLine("-----Video Player - Video MKV ---------");

        videoPlayer = new MkvVideo();

        videoPlayer.PlayVideo();

        Console.ReadKey();
    }
}

void MenuStore()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Executar o Padrão visitor");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void StoreVisitor()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

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
            Console.WriteLine($"{motorcycle.Model} {motorcycle.Name}: R${ motorcycle.Price }");
            stores.Add(motorcycle);
        }

        Console.WriteLine("\nAplicando o Padrão Visitor para calcular o preço com desconto\n");

        var priceVisitor = new PriceVisitor();

        foreach (var store in stores)
        {
            store.Visit(priceVisitor);
        }

        Console.ReadKey();
    }
}