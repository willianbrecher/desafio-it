using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Application.Interfaces
{
    public interface IApplicationQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        new Task<TResponse> Handle(TRequest query, CancellationToken cancellationToken);
    }
}
