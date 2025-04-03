// See https://aka.ms/new-console-template for more information
using Praticas.Enums;
using Praticas.Factories;

int value;
char option;

while (true)
{
    //MenuPessoa();
    MenuStudentFactory();
    try
    {
       //Pessoa();
       StudentFactory();
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