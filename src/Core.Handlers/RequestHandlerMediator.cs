using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMediator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<RequestHandlerMediator<TRequest, TResponse>> _logger;
        private readonly IMediator _mediator;

        protected RequestHandlerMediator(ILogger<RequestHandlerMediator<TRequest, TResponse>> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}