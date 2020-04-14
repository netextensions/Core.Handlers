using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerContext<TContext, TRequest, TResponse> : ContextHandler<TContext>, IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> where TContext : DbContext
    {
        protected RequestHandlerContext(ILogger<RequestHandlerContext<TContext, TRequest, TResponse>> logger, DbContextOptions<TContext> options) : base(logger, options)
        {
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
