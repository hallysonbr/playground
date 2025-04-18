﻿// See https://aka.ms/new-console-template for more information
using Praticas.Adapters;
using Praticas.ConcreteBuilders;
using Praticas.ConcreteImplementors;
using Praticas.ConcretePrototypes;
using Praticas.Directors;
using Praticas.Enums;
using Praticas.Factories;
using Praticas.Models;
using Praticas.RefinedAbstractions;
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
    MenuEmployee();
    try
    {
        //Pessoa();
        //StudentFactory();
        //MovieBuilder();
        //SoldierPrototype();
        //Singleton();
        //HighSchoolStudentAdapter();
        EmployeeBridge();
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