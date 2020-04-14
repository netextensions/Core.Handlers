using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMediator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly ILogger<RequestHandlerMediator<TRequest, TResponse>> Logger;
        protected readonly IMediator Mediator;

        protected RequestHandlerMediator(ILogger<RequestHandlerMediator<TRequest, TResponse>> logger, IMediator mediator)
        {
            Logger = logger;
            Mediator = mediator;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}