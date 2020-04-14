using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMapper<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> 
    {
        protected readonly ILogger<RequestHandlerMapper<TRequest, TResponse>> Logger;
        protected readonly IMapper Mapper;

        protected RequestHandlerMapper(ILogger<RequestHandlerMapper<TRequest, TResponse>> logger, IMapper mapper)
        {
            Logger = logger;
            Mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}