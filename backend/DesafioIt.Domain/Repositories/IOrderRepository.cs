using DesafioIt.Domain.DataTransferObjects.Orders;
using DesafioIt.Domain.Interfaces;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Repositories
{
    public interface IOrderRepository : ICommonRepository<OrderModel>
    {
        PageableResult<OrderModel> PageableList(OrderPageableListParams searchParams);
    }
}
