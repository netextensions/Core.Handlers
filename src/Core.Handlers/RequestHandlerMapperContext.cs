using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMapperContext<TContext, TRequest, TResponse> : RequestHandlerContext<TContext, TRequest, TResponse> where TRequest : IRequest<TResponse> where TContext : DbContext
    {
        protected IMapper Mapper;

        protected RequestHandlerMapperContext(ILogger<RequestHandlerContext<TContext, TRequest, TResponse>> logger, DbContextOptions<TContext> options, IMapper mapper) : base(logger, options)
        {
            Mapper = mapper;
        }
    }
}