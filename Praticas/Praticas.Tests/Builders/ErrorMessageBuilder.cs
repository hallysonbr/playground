using Praticas.Models;
using System.Net;

namespace Praticas.Tests.Builders
{
    public class ErrorMessageBuilder
    {
        private ErrorResponse _instance;

        public ErrorMessageBuilder()
        {
            _instance = new(HttpStatusCode.OK, "Success");
        }

        public ErrorResponse Build() => _instance;

        public ErrorMessageBuilder WithBadRequest()
        {
            _instance = new(HttpStatusCode.BadRequest, "Object request invalid");
            return this;
        }

        public ErrorMessageBuilder WithNotFound()
        {
            _instance = new(HttpStatusCode.NotFound, "Object not found");
            return this;
        }

        public ErrorMessageBuilder WithUnprocessableEntity()
        {
            _instance = new(HttpStatusCode.UnprocessableEntity, "Object cannot be processed");
            return this;
        }

        public ErrorMessageBuilder WithInternalServerError()
        {
            _instance = new(HttpStatusCode.InternalServerError, "Unexpected Error");
            return this;
        }
    }
}
