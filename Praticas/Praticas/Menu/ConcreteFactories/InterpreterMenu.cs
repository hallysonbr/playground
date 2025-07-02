using Praticas.Interpreters.AbstractExpressions;
using Praticas.Interpreters.ConcreteExpressions;
using Praticas.Interpreters.Contexts;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class InterpreterMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Data no formato MM-DD-YYYY");
            Console.WriteLine("2. Data no formato DD-MM-YYYY");
            Console.WriteLine("3. Data no formato YYYY-MM-DD");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                List<IDateAbstractExpression> expressions = new List<IDateAbstractExpression>();

                var dateOption = Option == '1' ? "MM-DD-YYYY" : Option == '2' ? "DD-MM-YYYY" : "YYYY-MM-DD";

                var context = new DateContext(DateTime.Now);

                Console.WriteLine($"Data atual: {context.Date}");

                context.Expression = dateOption;

                var formats = context.Expression.Split('-');

                foreach (var format in formats)
                {
                    switch (format)
                    {
                        case "MM":
                            expressions.Add(new MonthExpression());
                            break;
                        case "DD":
                            expressions.Add(new DayExpression());
                            break;
                        case "YYYY":
                            expressions.Add(new YearExpression());
                            break;
                        default:
                            throw new NotImplementedException("Format not implemented.");
                    }
                }

                expressions.Add(new SeparatorExpression());

                expressions.ForEach(x => x.Interpret(context));

                Console.WriteLine($"Data na expressão selecionada: {context.Expression}");
                Console.ReadKey();
            });
        }
    }
}
