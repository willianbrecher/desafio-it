using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Models.Dishes;

namespace DesafioIt.Application.Queries.Dishes
{
	public class DishDetailQuery : IApplicationQuery<DishModel>
    {
		public Guid Id { get; set; }
	}
}

