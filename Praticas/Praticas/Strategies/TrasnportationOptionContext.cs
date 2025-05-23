namespace Praticas.Strategies
{
    public class TrasnportationOptionContext
    {
        private Dictionary<char, ITransportationOption> _options;
        private ITransportationOption _transportationOption;

        public TrasnportationOptionContext()
        {
            _options = new();
            _options.TryAdd('1', new Car());
            _options.TryAdd('2', new Cab());
            _options.TryAdd('3', new AirPlane());
        }

        public void DefineStrategy(char option)
        {
            if (!_options.TryGetValue(option, out _transportationOption!))
                throw new NotImplementedException("Valor inválido");
        }

        public void ChooseTransportation(string passenger)
        {
            _transportationOption.ChooseTransportation(passenger);
            Console.WriteLine("\nFaça uma boa viagem!");
        }
    }
}
