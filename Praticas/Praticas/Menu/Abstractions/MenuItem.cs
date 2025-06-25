using Praticas.Factories;
using Praticas.Menu.Interfaces;

namespace Praticas.Menu.Abstractions
{
    public abstract class MenuItem : IMenu
    {
        protected int Value { get; set; }
        protected char Option { get; set; }
        protected bool Exit { get; set; }

        public abstract bool ShowMenu();

        protected bool ExecuteMenu(Action action)
        {
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && input.Length == 1)
            {
                Value = input[0];
                Option = (char)Value;

                Exit = Option == '9';

                if (char.IsLetterOrDigit(Option) && !Exit)
                {
                    action.Invoke();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(true);
                }
            }
            return Exit;
        }
    }
}
