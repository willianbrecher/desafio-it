using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models.Items;

namespace DesafioIt.Application.Queries.Items
{
	public class ItemDetailQuery : IApplicationQuery<ItemModel>
    {
		public Guid Id { get; set; }
	}
}

