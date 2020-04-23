using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMediatorMapperContext<TContext, TRequest, TResponse> : RequestHandlerContext<TContext, TRequest, TResponse> where TRequest : IRequest<TResponse> where TContext : DbContext
    {
        protected readonly IMediator Mediator;
        protected readonly IMapper Mapper;

        protected RequestHandlerMediatorMapperContext(ILogger<RequestHandlerContext<TContext, TRequest, TResponse>> logger, DbContextOptions<TContext> options, IMediator mediator, IMapper mapper) : base(logger, options)
        {
            Mediator = mediator;
            Mapper = mapper;
        }
    }
}