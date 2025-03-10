using Praticas.ChainOfResponsibility.Interfaces;
using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Handlers
{
    public class NotFoundHandler : IStatusCodeHandler
    {
        public ErrorResponse? Handle(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.NotFound) return new(HttpStatusCode.NotFound, "Object not found");

            return null;
        }
    }
}
