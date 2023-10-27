using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models.Items;

namespace DesafioIt.Application.Commands.Items
{
	public class CreateItemCommand : IApplicationCommand<ItemModel>
	{   
        public string Name { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public DateTimeOffset Disabled { get; set; }
    }
}

