using DesafioIt.Domain.DataTransferObjects.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Items;
using DesafioIt.Domain.Repositories;
using DesafioIt.EntityFramework.Common;
using DesafioIt.EntityFramework.Entities;
using Autofac;

namespace DesafioIt.EntityFramework.Repositories
{
    public class ItemRepository : CommonRepository<ItemEntity, ItemModel>, IItemRepository
    {
        public ItemRepository(IComponentContext context) : base(context)
        {
        }

        public PageableResult<ItemModel> PageableList(ItemPageableListParams searchParams)
        {
            var query = Queryable.Where(e => string.IsNullOrEmpty(searchParams.Filter) || e.Name == null || e.Name.ToLower().Contains(searchParams.Filter.ToLower()));

            query = searchParams.OrderBy switch
            {
                ItemPageableListOrderOptions.NAME_DESC => query.OrderByDescending(e => e.Name),
                _ => query.OrderBy(e => e.Name),
            };

            var results = query.Skip(searchParams.Skip).Take(searchParams.PageSize).ToList();

            return new PageableResult<ItemModel>(
                pageSize: searchParams.PageSize,
                currentPage: searchParams.CurrentPage,
                results: results.Select(a => Mapper.Map<ItemModel>(a)).ToList());
        }
    }
}
