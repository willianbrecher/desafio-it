using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models.Items;

namespace DesafioIt.Application.Commands.Items
{
	public class UpdateItemCommand : IApplicationCommand<ItemModel>
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public DateTimeOffset Disabled { get; set; }
    }
}

