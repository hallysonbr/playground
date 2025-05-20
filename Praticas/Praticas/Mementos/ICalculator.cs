namespace Praticas.Mementos
{
    public interface ICalculator
    {
        ICaretaker BackupLastCalculation();
        void RestoreLastCalculation(ICaretaker memento);
        int GetCalculationResult();
        void SetFirstNumber(int firstNumber);
        void SetSecondNumber(int secondNumber);
    }
}
