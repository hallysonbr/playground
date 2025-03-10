using Praticas.ChainOfResponsibility.Interfaces;
using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Handlers
{
    public class BadRequestHandler : IStatusCodeHandler
    {
        public ErrorResponse? Handle(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.BadRequest) return new(HttpStatusCode.BadRequest, "Object request invalid");

            return null;
        }
    }
}
