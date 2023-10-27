using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models;

namespace DesafioIt.Application.Commands.Dishes
{
	public class DeleteDishCommand : IApplicationCommand<EmptyResult>
    {
        public Guid Id { get; set; }
	}
}

