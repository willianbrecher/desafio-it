using AutoMapper;
using DesafioIt.Application.Commands.Orders;
using DesafioIt.Application.Interfaces;
using DesafioIt.Application.Queries.Orders;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Orders;
using DesafioIt.Domain.Repositories;
using Microsoft.VisualBasic.FileIO;

namespace DesafioIt.Application.Handlers.Orders
{
    public class OrderHandler : IApplicationCommandHandler<CreateOrderCommand, OrderModel>,
        IApplicationCommandHandler<UpdateOrderCommand, OrderModel>,
        IApplicationQueryHandler<OrderPageableListQuery, PageableResult<OrderModel>>
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IMapper _mapper;

        public OrderHandler(IOrderRepository OrderRepository, IMapper mapper)
        {
            _OrderRepository = OrderRepository;
            _mapper = mapper;
        }

        public Task<PageableResult<OrderModel>> Handle(OrderPageableListQuery query, CancellationToken cancellationToken)
        {
            PageableResult<OrderModel> results = _OrderRepository.PageableList(query);

            var result = new PageableResult<OrderModel>(
                pageSize: query.PageSize,
                currentPage: query.CurrentPage,
                results: results.Results
            );

            return Task.FromResult(result);
        }

        public Task<OrderModel> Handle(UpdateOrderCommand command, CancellationToken cancellationToken)
        {
            var dbOrder = _OrderRepository.Get(command.Id);
            dbOrder.Update(
                code: command.Code,
                clientName: command.ClientName,
                orderItems: command.OrderItems,
                status: command.Status,
                observation: command.Observation,
                totalPrice: command.TotalPrice
            );

            _OrderRepository.Save(dbOrder);
            return Task.FromResult(dbOrder);
        }

        public Task<OrderModel> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<OrderModel>(command);
            _OrderRepository.Insert(model);
            return Task.FromResult(model);
        }
    }
}
