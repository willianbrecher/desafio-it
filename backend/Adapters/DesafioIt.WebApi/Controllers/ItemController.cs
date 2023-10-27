using Autofac;
using DesafioIt.Application.Commands.Items;
using DesafioIt.Application.Queries.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Items;
using DesafioIt.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using EmptyResult = DesafioIt.Domain.Models.EmptyResult;

namespace DesafioIt.WebApi.Controllers
{
    public class ItemController : CommonController
    {
        public ItemController(IComponentContext context) : base(context)
        {
        }

        [HttpPost]
        [Route("pageable-list")]
        [ProducesResponseType(typeof(PageableResult<ItemModel>), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> PageableList([FromBody] ItemPageableListQuery query, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(query, cancellationToken));

        [HttpPost]
        [ProducesResponseType(typeof(ItemModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] CreateItemCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        [HttpPut]
        [ProducesResponseType(typeof(ItemModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] UpdateItemCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ItemModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Find([FromRoute] Guid id, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(new ItemDetailQuery() { Id = id }, cancellationToken));

        [HttpDelete]
        [ProducesResponseType(typeof(EmptyResult), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Delete([FromBody] DeleteItemCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));
    }
}
