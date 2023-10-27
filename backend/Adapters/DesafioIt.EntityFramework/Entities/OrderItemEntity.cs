using DesafioIt.Domain.Attributes;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Orders;
using DesafioIt.EntityFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.EntityFramework.Entities
{
    [AutoMap(typeof(OrderItemModel), AutoMapperDirections.Both)]
    public class OrderItemEntity : AuditableEntity
    {
        public Guid OrderId { get; set; }
        // Dish
        public Guid DishId { get; set; }
        // Quant
        public int Quantity { get; set; }

    }
}
