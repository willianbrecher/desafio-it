using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models;

namespace DesafioIt.Application.Commands.Orders
{
	public class DeleteOrderCommand : IApplicationCommand<EmptyResult>
    {
        public Guid Id { get; set; }
	}
}

