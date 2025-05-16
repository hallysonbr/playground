using Praticas.Interpreters.AbstractExpressions;
using Praticas.Interpreters.Contexts;

namespace Praticas.Interpreters.ConcreteExpressions
{
    public class MonthExpression : IDateAbstractExpression
    {
        public void Interpret(DateContext context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
