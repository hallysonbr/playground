namespace Praticas.Mementos
{
    /// <summary>
    /// Originator
    /// </summary>
    public class Calculator : ICalculator
    {
        private int _firstNumber;
        private int _secondNumber;

        public ICaretaker BackupLastCalculation()
        {
            return new Memento(_firstNumber, _secondNumber);
        }

        public void RestoreLastCalculation(ICaretaker memento)
        {
            if (memento is Memento mementoObj)
            {
                _firstNumber = mementoObj.GetFirstNumber();
                _secondNumber = mementoObj.GetSecondNumber();
            }
        }

        public int GetCalculationResult()
        {
            return _firstNumber + _secondNumber;
        }

        public void SetFirstNumber(int firstNumber)
        {
            _firstNumber = firstNumber;
        }

        public void SetSecondNumber(int secondNumber)
        {
            _secondNumber = secondNumber;
        }
    }
}
