using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Dishes;

namespace DesafioIt.Application.Commands.Dishes
{
	public class SeedOrdersCommand : IApplicationCommand<DishModel>
	{
        public List<DishModel> Dishes { get; set; }
    }
}

