using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMediatorContext<TContext, TRequest, TResponse> : RequestHandlerContext<TContext, TRequest, TResponse> where TRequest : IRequest<TResponse> where TContext : DbContext
    {
        protected IMediator Mediator;

        protected RequestHandlerMediatorContext(ILogger<RequestHandlerContext<TContext, TRequest, TResponse>> logger, DbContextOptions<TContext> options, IMediator mediator) : base(logger, options)
        {
            Mediator = mediator;
        }
    }
}