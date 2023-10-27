using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Dishes;

namespace DesafioIt.Application.Commands.Dishes
{
	public class UpdateDishCommand : IApplicationCommand<DishModel>
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ServingSize { get; set; }
        public DishType Type { get; set; }
    }
}

