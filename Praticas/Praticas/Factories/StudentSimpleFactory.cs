namespace Praticas.Factories
{
    public class StudentSimpleFactory
    {
        public static StudentFactoryMethod CreateFactory(char option) => option switch
        {
            '1' => new StudentFilialAFactory(),
            '2' => new StudentFilialBFactory(),
            _ => throw new NotImplementedException("Filial invalida."),
        };
    }
}
