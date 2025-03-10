using System.Net;

namespace Praticas.Models
{
    public class ErrorResponse
    {
        public ErrorResponse(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public HttpStatusCode StatusCode { get; private set; }
        public string Message { get; private set; }
    }
}
