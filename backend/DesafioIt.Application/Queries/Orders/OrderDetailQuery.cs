using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models.Orders;

namespace DesafioIt.Application.Queries.Orders
{
	public class OrderDetailQuery : IApplicationQuery<OrderModel>
    {
		public Guid Id { get; set; }
		public int Code { get; set; }
	}
}

