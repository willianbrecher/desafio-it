using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Application.Interfaces
{
    public interface IApplicationCommand<ReturnObjectType> : IRequest<ReturnObjectType>
    {
    }
}
