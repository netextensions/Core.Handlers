using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace NetExtensions
{
    public abstract class RequestHandlerMapper<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> 
    {
        private readonly ILogger<RequestHandlerMapper<TRequest, TResponse>> _logger;
        private readonly IMapper _mapper;

        protected RequestHandlerMapper(ILogger<RequestHandlerMapper<TRequest, TResponse>> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}