// See https://aka.ms/new-console-template for more information
using Praticas.ConcreteBuilders;
using Praticas.ConcretePrototypes;
using Praticas.Directors;
using Praticas.Enums;
using Praticas.Factories;

int value;
char option;

while (true)
{
    //MenuPessoa();
    //MenuStudentFactory();
    //MenuMovie();
    MenuSoldier();
    try
    {
        //Pessoa();
        //StudentFactory();
        //MovieBuilder();
        SoldierPrototype();
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