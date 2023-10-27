using System;
using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.Attributes;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Dishes;

namespace DesafioIt.Application.Commands.Dishes
{
    [AutoMap(typeof(DishModel), AutoMapperDirections.Both)]
    public class CreateDishCommand : IApplicationCommand<DishModel>
	{

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ServingSize { get; set; }
        public string Photo { get; set; }
        public DishType Type { get; set; }
    }
}

