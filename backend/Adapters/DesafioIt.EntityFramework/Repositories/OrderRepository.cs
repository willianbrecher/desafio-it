using DesafioIt.Domain.DataTransferObjects.Orders;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Orders;
using DesafioIt.Domain.Repositories;
using DesafioIt.EntityFramework.Common;
using DesafioIt.EntityFramework.Entities;
using Autofac;

namespace DesafioIt.EntityFramework.Repositories
{
    public class OrderRepository : CommonRepository<OrderEntity, OrderModel>, IOrderRepository
    {
        public OrderRepository(IComponentContext context) : base(context)
        {
        }

        public PageableResult<OrderModel> PageableList(OrderPageableListParams searchParams)
        {
            var query = Queryable.Where(e => string.IsNullOrEmpty(searchParams.Filter) || e.Code == null || e.Code.ToString().ToLower().Contains(searchParams.Filter.ToLower()));

            query = searchParams.OrderBy switch
            {
                OrderPageableListOrderOptions.NAME_DESC => query.OrderByDescending(e => e.Code),
                _ => query.OrderBy(e => e.Code),
            };

            var results = query.Skip(searchParams.Skip).Take(searchParams.PageSize).ToList();

            return new PageableResult<OrderModel>(
                pageSize: searchParams.PageSize,
                currentPage: searchParams.CurrentPage,
                results: results.Select(a => Mapper.Map<OrderModel>(a)).ToList());
        }
    }
}
