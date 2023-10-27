using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace DesafioIt.Application.Interfaces;

public interface IApplicationCommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    new Task<TResponse> Handle(TRequest command, CancellationToken cancellationToken);
}