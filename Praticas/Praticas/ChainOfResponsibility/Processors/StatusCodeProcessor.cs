using Praticas.ChainOfResponsibility.Handlers;
using Praticas.ChainOfResponsibility.Interfaces;
using Praticas.Models;
using System.Net;

namespace Praticas.ChainOfResponsibility.Processors
{
    public class StatusCodeProcessor
    {
        private readonly IEnumerable<IStatusCodeHandler> _handlers;

        public StatusCodeProcessor()
        {
            _handlers = new List<IStatusCodeHandler>()
            {
                new BadRequestHandler(),
                new NotFoundHandler(),
                new UnprocessableEntityHandler(),
                new InternalServerErrorHandler()
            };
        }

        public ErrorResponse? Process(HttpStatusCode statusCode)
        {
            foreach (var handler in _handlers)
            {
                var result = handler.Handle(statusCode);
                if (result is not null) return result;
            }

            return null;
        }
    }
}
