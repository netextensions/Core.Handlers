using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerBase<TContext, TRequest, TResponse> : Repository<TContext>, IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> where TContext : DbContext, new()
    {
        protected IMapper Mapper;

        protected RequestHandlerBase(ILogger<RequestHandlerBase<TContext, TRequest, TResponse>> logger, DbContextOptions<TContext> options, IMapper mapper) : base(logger, options)
        {
            Mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
