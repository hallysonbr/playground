namespace Praticas.Handlers
{
    public abstract class AuthorizerHandler
    {
        protected AuthorizerHandler _authorizer;

        public AuthorizerHandler SetNext(AuthorizerHandler authorizer)
        {
            _authorizer = authorizer;
            return _authorizer;
        }

        public abstract void Handle(string name, int days);
    }
}
