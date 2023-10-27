using Autofac;
using DesafioIt.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioIt.WebApi.Controllers
{
    public abstract class CommonController : ControllerBase
    {
        protected IMediator Mediator { get; }
        protected IComponentContext Context { get; }

        protected CommonController(IComponentContext context)
        {
            Mediator = context.Resolve<IMediator>();
        }
    }
}
