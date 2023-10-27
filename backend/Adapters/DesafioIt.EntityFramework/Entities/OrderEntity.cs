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
    [AutoMap(typeof(OrderModel), AutoMapperDirections.Both)]
    public class OrderEntity : AuditableEntity
    {
        // codigo do pedido
        public int Code { get; set; }
        // Nome cliente
        public string ClientName { get; set; }
        // lista de pratos
        public List<OrderItemEntity> OrderItems { get; set; }
        // Status
        public OrderStatus Status { get; set; }
        // Observação
        public string Observation { get; set; }
        // preço total
        public double TotalPrice { get; set; }
    }
}
