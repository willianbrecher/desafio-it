using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.DataTransferObjects.Orders;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Orders;

namespace DesafioIt.Application.Queries.Orders
{
    public class OrderPageableListQuery : OrderPageableListParams, IApplicationQuery<PageableResult<OrderModel>>
    {
    }
}
