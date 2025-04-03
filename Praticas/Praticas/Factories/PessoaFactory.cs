using Praticas.Interfaces;
using Praticas.Services;

namespace Praticas.Factories
{
    public static class PessoaFactory
    {
        private static Dictionary<char, IGetPessoaBase> _options;

        static PessoaFactory()
        {
            _options = new();
            AddOptions();
        }

        private static void AddOptions()
        {
            _options.TryAdd('0', new GetPessoaFisicaService());
            _options.TryAdd('1', new GetPessoaJuridicaService());
        }

        public static IGetPessoaBase GetPessoa(char option) => option switch
        {
            '0' => new GetPessoaFisicaService(),
            '1' => new GetPessoaJuridicaService(),
            _ => throw new NotImplementedException("Valor inválido")
        };

        public static IGetPessoaBase InitPessoa(char option)
        {
            IGetPessoaBase result;

            if (_options.TryGetValue(option, out result!)) return result;

            throw new NotImplementedException("Valor inválido");
        }
    }
}
