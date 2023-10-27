using DesafioIt.Domain.Attributes;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Dishes;
using DesafioIt.EntityFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.EntityFramework.Entities
{
    [AutoMap(typeof(DishModel), AutoMapperDirections.Both)]
    public class DishEntity : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ServingSize { get; set; }
        public string Photo { get; set; }
        public DishType Type { get; set; }
    }
}
