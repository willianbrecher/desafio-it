using DesafioIt.Domain.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesafioIt.Domain.Models.Orders
{
    public class OrderModel : EntityModel
    {
        public OrderModel(int code, string clientName, List<OrderItemModel> orderItems, OrderStatus status, string observation, double totalPrice, Guid? id) : base(id)
        {
            Code = code;
            ClientName = clientName;
            OrderItems = orderItems;
            Status = status;
            Observation = observation;
            TotalPrice = totalPrice;
        }

        public int Code { get; set; }
        public string ClientName { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
        public OrderStatus Status { get; set; }
        public string Observation { get; set; }
        public double TotalPrice { get; set; }


        public void Update(int code, string clientName, List<OrderItemModel> orderItems, OrderStatus status, string observation, double totalPrice)
        {
            Code = code;
            ClientName = clientName;
            OrderItems = orderItems;
            Status = status;
            Observation = observation;
            TotalPrice = totalPrice;
        }
    }
}
