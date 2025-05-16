using Praticas.Interpreters.AbstractExpressions;
using Praticas.Interpreters.Contexts;

namespace Praticas.Interpreters.ConcreteExpressions
{
    public class YearExpression : IDateAbstractExpression
    {
        public void Interpret(DateContext context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
