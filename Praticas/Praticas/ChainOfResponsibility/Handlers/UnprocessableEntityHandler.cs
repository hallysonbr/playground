using Praticas.ChainOfResponsibility.Interfaces;
using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Handlers
{
    public class UnprocessableEntityHandler : IStatusCodeHandler
    {
        public ErrorResponse? Handle(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.UnprocessableEntity) return new(HttpStatusCode.UnprocessableEntity, "Object cannot be processed");

            return null;
        }
    }
}
