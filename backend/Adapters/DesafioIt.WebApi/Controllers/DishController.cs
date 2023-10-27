using Autofac;
using DesafioIt.Application.Commands.Dishes;
using DesafioIt.Application.Queries.Dishes;
using DesafioIt.Application.Queries.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;
using DesafioIt.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using EmptyResult = DesafioIt.Domain.Models.EmptyResult;

namespace DesafioIt.WebApi.Controllers
{
    [Route("api/dishes")]
    [ApiController]
    public class DishController : CommonController
    {
        public DishController(IComponentContext context) : base(context)
        {
        }

        [HttpPost]
        [Route("pageable-list")]
        [ProducesResponseType(typeof(PageableResult<DishModel>), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> PageableList([FromBody] DishPageableListQuery query, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(query, cancellationToken));

        [HttpPost]
        [ProducesResponseType(typeof(DishModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] CreateDishCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        [HttpPut]
        [ProducesResponseType(typeof(DishModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] UpdateDishCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(DishModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Find([FromRoute] Guid id, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(new DishDetailQuery() { Id = id }, cancellationToken));

        [HttpDelete]
        [ProducesResponseType(typeof(EmptyResult), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Delete([FromBody] DeleteDishCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));
    }
}
