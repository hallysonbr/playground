using Praticas.Interpreters.Contexts;

namespace Praticas.Interpreters.AbstractExpressions
{
    public interface IDateAbstractExpression
    {
        void Interpret(DateContext context);
    }
}
