namespace Praticas.States
{
    public interface IAtmMachineState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin();
        void RequestCash();
    }
}
