using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models;

namespace DesafioIt.Application.Commands.Items
{
	public class DeleteItemCommand : IApplicationCommand<EmptyResult>
    {
        public Guid Id { get; set; }
	}
}

