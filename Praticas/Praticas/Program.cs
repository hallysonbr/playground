// See https://aka.ms/new-console-template for more information
using Praticas.Adapters;
using Praticas.Composites;
using Praticas.ConcreteBuilders;
using Praticas.ConcreteComponents;
using Praticas.ConcreteDecorators;
using Praticas.ConcreteImplementors;
using Praticas.ConcretePrototypes;
using Praticas.Directors;
using Praticas.Enums;
using Praticas.Facades;
using Praticas.Factories;
using Praticas.Leafs;
using Praticas.Models;
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
    MenuLoan();

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
        LoanFacade();
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
        var client = new Client("João");

        var result = loan.GrantLoan(client, 1500000.00);

        Console.WriteLine($"The loan requested for {client.Name} was { (result ? "Approved" : "Rejected") }");
        Console.ReadKey();
    }
}