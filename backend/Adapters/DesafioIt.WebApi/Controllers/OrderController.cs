using Autofac;
using DesafioIt.Application.Commands.Orders;
using DesafioIt.Application.Queries.Orders;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Orders;
using DesafioIt.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using EmptyResult = DesafioIt.Domain.Models.EmptyResult;

namespace DesafioIt.WebApi.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrderController : CommonController
    {
        public OrderController(IComponentContext context) : base(context)
        {
        }
        /// <summary>
        /// Returns a pageable list of orders.
        /// </summary>
        /// <param name="query">The order pageable list query.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The IActionResult representing the result of the operation.
        /// If the operation is successful, the result is a 200 OK response
        /// containing a PageableResult&lt;OrderModel&gt; object.
        /// If an exception occurs, the result is a 500 Internal Server Error
        /// response containing an ExceptionResponse object.
        /// </returns>
        [HttpPost]
        [Route("pageable-list")]
        [ProducesResponseType(typeof(PageableResult<OrderModel>), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> PageableList([FromBody] OrderPageableListQuery query, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(query, cancellationToken));

        /// <summary>
        /// Saves the specified order.
        /// </summary>
        /// <param name="command">The order create command.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The IActionResult representing the result of the operation.
        /// If the operation is successful, the result is a 200 OK response
        /// containing an OrderModel object.
        /// If an exception occurs, the result is a 500 Internal Server Error
        /// response containing an ExceptionResponse object.
        /// </returns>
        [HttpPost]
        [ProducesResponseType(typeof(OrderModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] CreateOrderCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        /// <summary>
        /// Saves the order by updating it with the provided command.
        /// </summary>
        /// <param name="command">The UpdateOrderCommand object that contains the data for updating the order.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation.</param>
        /// <returns>An IActionResult object representing the result of the save operation.
        /// Returns a 200 status code if the save is successful, along with the updated order model.
        /// Returns a 500 status code if an exception occurs during the save operation, along with the exception response.</returns>
        [HttpPut]
        [ProducesResponseType(typeof(OrderModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Save([FromBody] UpdateOrderCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(OrderModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Find([FromRoute] Guid id, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(new OrderDetailQuery() { Id = id }, cancellationToken));

        [HttpGet]
        [Route("{code}")]
        [ProducesResponseType(typeof(OrderModel), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Find([FromRoute] int code, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(new OrderDetailQuery() { Code = code }, cancellationToken));

        [HttpDelete]
        [ProducesResponseType(typeof(EmptyResult), 200)]
        [ProducesResponseType(typeof(ExceptionResponse), 500)]
        public async Task<IActionResult> Delete([FromBody] DeleteOrderCommand command, CancellationToken cancellationToken) =>
            Ok(await Mediator.Send(command, cancellationToken));

    }
}
