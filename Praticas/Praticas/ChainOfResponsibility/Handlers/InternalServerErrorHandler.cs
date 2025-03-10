using Praticas.ChainOfResponsibility.Interfaces;
using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Handlers
{
    public class InternalServerErrorHandler : IStatusCodeHandler
    {
        public ErrorResponse? Handle(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.InternalServerError) return new(HttpStatusCode.InternalServerError, "Unexpected Error");

            return null;
        }
    }
}
