using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Models.Orders
{
    public class OrderItemModel : EntityModel
    {
        public OrderItemModel(Guid orderId, Guid dishId, int quantity, Guid? id) : base(id)
        {
            OrderId = orderId;
            DishId = dishId;
            Quantity = quantity;
        }

        public Guid OrderId { get; set; }
        public Guid DishId { get; set; }
        public int Quantity { get; set; }
    }
}
