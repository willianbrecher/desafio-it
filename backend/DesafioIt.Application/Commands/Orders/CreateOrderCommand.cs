using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Orders;

namespace DesafioIt.Application.Commands.Orders
{
	public class CreateOrderCommand : IApplicationCommand<OrderModel>
	{
        public int Code { get; set; }
        public string ClientName { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
        public OrderStatus Status { get; set; }
        public string Observation { get; set; }
        public double TotalPrice { get; set; }
    }
}

