// See https://aka.ms/new-console-template for more information
using Praticas.Adapters;
using Praticas.Commands;
using Praticas.Composites;
using Praticas.ConcreteBuilders;
using Praticas.ConcreteComponents;
using Praticas.ConcreteDecorators;
using Praticas.ConcreteHandlers;
using Praticas.ConcreteImplementors;
using Praticas.ConcretePrototypes;
using Praticas.Directors;
using Praticas.Enums;
using Praticas.Facades;
using Praticas.Factories;
using Praticas.Flyweights;
using Praticas.Interpreters.AbstractExpressions;
using Praticas.Interpreters.ConcreteExpressions;
using Praticas.Interpreters.Contexts;
using Praticas.Iterators;
using Praticas.Leafs;
using Praticas.Mediators;
using Praticas.Mementos;
using Praticas.Models;
using Praticas.Proxies;
using Praticas.RefinedAbstractions;
using Praticas.Subsystems;
using Praticas.Targets;

int value;
char option;

while (true)
{
    //MenuPessoa();
    //MenuStudentFactory();
    //MenuMovie();
    //MenuSoldier();
    //MenuSingleton();
    //MenuHighSchoolStudent();
    //MenuEmployee();
    //MenuWorkingHours();
    //MenuCar();
    //MenuLoan();
    //MenuShape();
    //MenuSharedFolder();
    //MenuDayOff();
    //MenuRestaurant();
    //MenuDate();
    //MenuClient();
    //MenuMessageGroup();
    MenuCalculator();

    
    try
    {
        //Pessoa();
        //StudentFactory();
        //MovieBuilder();
        //SoldierPrototype();
        //Singleton();
        //HighSchoolStudentAdapter();
        //EmployeeBridge();
        //WorkingHoursComposite();
        //CarDecorator();
        //LoanFacade();
        //ShapeFlyweight();
        //SharedFolderProxy();
        //DayOffChainOfResponsibility();
        //RestaurantCommand();
        //DateInterpreter();
        //ClientIterator();
        //MessageGroupMediator();
        CalculatorMemento();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        Console.ReadKey();
    }
}

void MenuPessoa()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("0. Pessoa Física");
    Console.WriteLine("1. Pessoa Jurídica");

    value = Console.Read();
    option = Convert.ToChar(value);
}

void MenuStudentFactory()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das Filais abaixo:");
    Console.WriteLine("1. Filial A");
    Console.WriteLine("2. Pessoa B");

    value = Console.Read();
    option = Convert.ToChar(value);
}

void Pessoa()
{
    if (char.IsLetterOrDigit(option))
    {
        //var pessoaService = PessoaFactory.GetPessoa(option);
        var pessoaService = PessoaFactory.InitPessoa(option);
        var result = pessoaService.GetPessoa();
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

void StudentFactory()
{
    if (!char.IsLetterOrDigit(option)) return;

    var typeOption = new Random().Next(0, 2);
    var studentFactoryMethod = StudentSimpleFactory.CreateFactory(option);
    var student = studentFactoryMethod.CreateStudent((StudentTypeEnum)typeOption);
    Console.WriteLine(student.Assign());
    Console.ReadKey();
}

void MenuMovie()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Criar Filme");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void MovieBuilder()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var cinema = new Cinema(new CinemarkBuilder());
        cinema.InitMovie();
        var cinemarkMovie = cinema.GetMovie();        

        cinema = new Cinema(new CinepolisBuilder());
        cinema.InitMovie();
        var cinepolisMovie = cinema.GetMovie();

        Console.WriteLine(cinemarkMovie.ShowMovie());
        Console.WriteLine(cinepolisMovie.ShowMovie());
        Console.ReadKey();
    }
}

void MenuSoldier()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Soldado");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void SoldierPrototype()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var soldier = new Soldier();
        soldier.Name = "Soldier Boy";
        soldier.Gun = "AK-47";
        soldier.Acessory = new Acessory { Name = "Óculos de visão noturna " };

        var clone1 = (Soldier)soldier.Clone();
        clone1.Name = "Soldier Clone 1";
        clone1.Gun = "Desert Eagle";
        clone1.Acessory.Name = "Colete à prova de balas";

        var clone2 = (Soldier)soldier.Clone();
        clone2.Name = "Soldier Clone 2";
        clone2.Gun = "M4A1";
        clone2.Acessory.Name = "Coquetel Molotov";
        
        Console.WriteLine("Shallow Copy");

        Console.WriteLine("Soldado Original");
        Console.WriteLine($"Nome: {soldier.Name} - Arma: {soldier.Gun} - Acessório: {soldier.Acessory.Name}");
       
        Console.WriteLine("Clone 1");
        Console.WriteLine($"Nome: {clone1.Name} - Arma: {clone1.Gun} - Acessório: {clone1.Acessory.Name}");

        Console.WriteLine("Clone 2");
        Console.WriteLine($"Nome: {clone2.Name} - Arma: {clone2.Gun} - Acessório: {clone2.Acessory.Name}");

        soldier.Acessory = new Acessory { Name = "Óculos de visão noturna " };

        clone1 = (Soldier)soldier.DeepClone();
        clone1.Name = "Soldier Clone 1";
        clone1.Gun = "Desert Eagle";
        clone1.Acessory.Name = "Colete à prova de balas";

        clone2 = (Soldier)soldier.DeepClone();
        clone2.Name = "Soldier Clone 2";
        clone2.Gun = "M4A1";
        clone2.Acessory.Name = "Coquetel Molotov";
        
        Console.WriteLine("Deep Copy");

        Console.WriteLine("Soldado Original");
        Console.WriteLine($"Nome: {soldier.Name} - Arma: {soldier.Gun} - Acessório: {soldier.Acessory.Name}");
       
        Console.WriteLine("Clone 1");
        Console.WriteLine($"Nome: {clone1.Name} - Arma: {clone1.Gun} - Acessório: {clone1.Acessory.Name}");

        Console.WriteLine("Clone 2");
        Console.WriteLine($"Nome: {clone2.Name} - Arma: {clone2.Gun} - Acessório: {clone2.Acessory.Name}");

        Console.ReadKey();
    }
}

void MenuSingleton()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Singleton");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void Singleton()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        Console.WriteLine("Criando uma instância do Singleton...");
        var instance1 = Praticas.Singleton.Singleton.Instance;

        Console.WriteLine("Criando uma segunda instância do Singleton...");
        var instance2 = Praticas.Singleton.Singleton.Instance;

        if (instance1 == instance2) Console.WriteLine("Instancias iguais!");
        else Console.WriteLine("Instancias diferentes!");


        Console.WriteLine("Criando uma instância do Singleton Thread Safe...");
        Parallel.Invoke(
            () => { Console.WriteLine($"Thread 1: {Praticas.Singleton.Singleton.InstanceTheadSafe}"); },
            () => { Console.WriteLine($"Thread 2: {Praticas.Singleton.Singleton.InstanceTheadSafe}"); }
        );

        Console.ReadKey();
    }
}

void MenuHighSchoolStudent()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Processar mensalidade");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void HighSchoolStudentAdapter()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var students = new string[4, 4]
        {
            { Guid.NewGuid().ToString(), "João", "Matemática", "100" },
            { Guid.NewGuid().ToString(), "Maria", "Física", "200" },
            { Guid.NewGuid().ToString(), "Joana", "Português", "300" },
            { Guid.NewGuid().ToString(), "José", "Química", "400" }
        };

        Console.WriteLine("Processando mensalidade...");

        IHighSchoolStudentTarget studentAdapter = new HighSchoolStudentAdapter();
        studentAdapter.ProcessMonthlyFee(students);

        Console.WriteLine("Mensalidades processadas!");
        Console.ReadKey();
    }
}

void MenuEmployee()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Gravar Arquivo json");
    Console.WriteLine("2. Gravar Arquivo xml");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void EmployeeBridge()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1' && option != '2') return;

        CalculateSalary calculateSalary;
       
        switch (option)
        {
            case '1':
                calculateSalary = new CalculateSalary(new WriteJson());
                break;
            case '2':
                calculateSalary = new CalculateSalary(new WriteXml());
                break;
            default:
                calculateSalary = new CalculateSalary(new WriteJson());
                break;
        }

        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            Name = "João",
            BaseSalary = 1000,
            Gratification = option == '1' ? 700 : 800
        };

        calculateSalary.ProcessSalary(employee);

        Console.ReadKey();
    }
}

void MenuWorkingHours()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Gerar Horas Trabalhadas por Departamento");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void WorkingHoursComposite()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var organization = new Organization { Name = "Empresa X" };

        var departamentIT = new Organization { Name = "Departamento de TI" };

        departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "João", Hours = 8 });
        departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Maria", Hours = 12 });
        departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Joana", Hours = 10 });

        var departamentHR = new Organization { Name = "Departamento de RH" };

        departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Jessé", Hours = 6 });
        departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Alberto", Hours = 9 });
        departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Cassia", Hours = 5 });

        organization.Add(departamentIT);
        organization.Add(departamentHR);
        organization.GetWorkingHours();
        
        Console.ReadKey();
    }
}

void MenuCar()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Criar Carro");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void CarDecorator()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var car = new Car();
        Console.WriteLine("Criando um carro versão básica");
        Console.WriteLine($"Preço do carro: { car.Price() }");
        Console.WriteLine($"Opcionais do carro: { car.Optionals() }");

        Console.WriteLine("-----Aplicando o Padrão Decorator-----");

        var car2 = new Car();
        var confortCar = new ConfortCarDecorator(car2);

        Console.WriteLine("Adicionando o pacote confort");
        Console.WriteLine($"Preço do carro: { confortCar.Price() }");
        Console.WriteLine($"Opcionais do carro: { confortCar.Optionals() }");

        var sportCar = new SportCarDecorator(confortCar);
        Console.WriteLine("Adicionando o pacote sport");
        Console.WriteLine($"Preço do carro: {sportCar.Price()}");
        Console.WriteLine($"Opcionais do carro: {sportCar.Optionals()}");

        Console.ReadKey();
    }
}

void MenuLoan()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Conceder Emprestimo");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void LoanFacade()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;
        
        var loan = new GrantLoanFacade();
        var client = new Praticas.Subsystems.Client("João");

        var result = loan.GrantLoan(client, 1500000.00);

        Console.WriteLine($"The loan requested for {client.Name} was { (result ? "Approved" : "Rejected") }");
        Console.ReadKey();
    }
}

void MenuShape()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Criar circulos de variadas cores.");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void ShapeFlyweight()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var colors = new[] { "Red", "Green", "Blue", "Black", "White" };
        for (int i = 0; i < 10; i++)
        {
            var circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor(colors[i % colors.Length]);
            circle.Draw();
        }
        Console.ReadKey();
    }
}

void MenuSharedFolder()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Acessar pasta compartilhada.");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void SharedFolderProxy()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        Console.WriteLine("Acessando pasta compartilhada...");

        Console.WriteLine("Perfil Desenvolvedor tentanto acessar a pasta...");
        var user1 = new Praticas.Proxies.User("João", "123456", "desenvolvedor");
        var sharedFolder1 = new SharedFolderProxy(user1);
        sharedFolder1.ReadAndWrite();

        Console.WriteLine("Perfil Visitante tentanto acessar a pasta...");
        var user2 = new Praticas.Proxies.User("Maria", "654321", "visitante");
        var sharedFolder2 = new SharedFolderProxy(user2);
        sharedFolder2.ReadAndWrite();

        Console.WriteLine("Perfil Administrador tentanto acessar a pasta...");
        var user3 = new Praticas.Proxies.User("José", "789456", "admin");
        var sharedFolder3 = new SharedFolderProxy(user3);
        sharedFolder3.ReadAndWrite();

        Console.ReadKey();
    }
}

void MenuDayOff()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Solicitar dias de licença.");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void DayOffChainOfResponsibility()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        ProjectManager projectManager = new ();
        TeamSupervisor teamSupervisor = new();
        HRDepartment hRDepartment = new();

        projectManager
            .SetNext(teamSupervisor)
            .SetNext(hRDepartment);

        projectManager.Handle("Ana", 5);
        projectManager.Handle("João", 10);
        projectManager.Handle("Maria", 20);
        projectManager.Handle("Alberto", 40);

        Console.ReadKey();
    }
}

void MenuRestaurant()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Fazer pedido.");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void RestaurantCommand()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var chef = new Chef();
        
        var order = new Order(chef, "Meal");
        var waiter = new Waiter(order);
        waiter.Execute();

        order = new Order(chef, "Dessert");
        waiter = new Waiter(order);
        waiter.Execute();

        Console.ReadKey();
    }
}

void MenuDate()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Data no formato MM-DD-YYYY");
    Console.WriteLine("2. Data no formato DD-MM-YYYY");
    Console.WriteLine("3. Data no formato YYYY-MM-DD");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void DateInterpreter()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1' && option != '2' && option != '3') return;

        List<IDateAbstractExpression> expressions = new List<IDateAbstractExpression>();

        var dateOption = option == '1' ? "MM-DD-YYYY" : option == '2' ? "DD-MM-YYYY" : "YYYY-MM-DD";

        var context = new DateContext(DateTime.Now);

        Console.WriteLine($"Data atual: {context.Date}");

        context.Expression = dateOption;

        var formats = context.Expression.Split('-');

        foreach (var format in formats)
        {
            switch (format)
            {
                case "MM":
                    expressions.Add(new MonthExpression());
                    break;
                case "DD":
                    expressions.Add(new DayExpression());
                    break;
                case "YYYY":
                    expressions.Add(new YearExpression());
                    break;
                default:
                    throw new NotImplementedException("Format not implemented.");
            }
        }

        expressions.Add(new SeparatorExpression());

        expressions.ForEach(x => x.Interpret(context));

        Console.WriteLine($"Data na expressão selecionada: {context.Expression}");
        Console.ReadKey();
    }
}

void MenuClient()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Criar Cliente com Iterator");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void ClientIterator()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

        var collection = new ConcreteCollection();

        collection.Add(new Praticas.Iterators.Client(1, "João"));
        collection.Add(new Praticas.Iterators.Client(2, "Maria"));
        collection.Add(new Praticas.Iterators.Client(3, "José"));

        var iterator = collection.CreateIterator();

        Console.WriteLine("Iterando sobre os clientes:");

        for (var client = iterator.First(); !iterator.IsDone; client = iterator.Next())
        {
            Console.WriteLine($"Nome: {client.Name}, Id: {client.Id}");
        }

        Console.ReadKey();
    }
}

void MenuMessageGroup()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1. Iniciar conversas no grupo");
    value = Console.Read();
    option = Convert.ToChar(value);
}

void MessageGroupMediator()
{
    if (char.IsLetterOrDigit(option))
    {
        if (option != '1') return;

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