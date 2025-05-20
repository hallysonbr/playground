namespace Praticas.Mementos
{
    public class Memento : ICaretaker, IOriginator
    {
        private int _firstNumber;
        private int _secondNumber;

        public Memento(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public int GetFirstNumber()
        {
            return _firstNumber;
        }

        public int GetSecondNumber()
        {
            return _secondNumber;
        }
    }
}
