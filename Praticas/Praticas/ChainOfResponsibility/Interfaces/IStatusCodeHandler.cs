using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Interfaces
{
    public interface IStatusCodeHandler
    {
        ErrorResponse? Handle(HttpStatusCode statusCode);
    }
}
