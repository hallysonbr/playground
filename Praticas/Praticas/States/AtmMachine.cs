namespace Praticas.States
{
    public class AtmMachine : IAtmMachineState
    {
        private IAtmMachineState _currentState;

        public AtmMachine()
        {
            _currentState = new CardNotInsertedState();
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
            _currentState = new CardInsertedState();
            Console.WriteLine($"Estado atual: {_currentState.GetType().Name}");
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
            _currentState = new CardNotInsertedState();
            Console.WriteLine($"Estado atual: {_currentState.GetType().Name}");
        }

        public void EnterPin()
        {
            _currentState.EnterPin();
        }

        public void RequestCash()
        {
            _currentState.RequestCash();
        }

        public IAtmMachineState GetCurrentState()
        {
            return _currentState;
        }
    }
}
