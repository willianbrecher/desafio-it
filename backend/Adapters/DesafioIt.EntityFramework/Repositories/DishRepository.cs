using DesafioIt.Domain.DataTransferObjects.Dishes;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;
using DesafioIt.Domain.Repositories;
using DesafioIt.EntityFramework.Common;
using DesafioIt.EntityFramework.Entities;
using Autofac;

namespace DesafioIt.EntityFramework.Repositories
{
    public class DishRepository : CommonRepository<DishEntity, DishModel>, IDishRepository
    {
        public DishRepository(IComponentContext context) : base(context)
        {
        }

        public PageableResult<DishModel> PageableList(DishPageableListParams searchParams)
        {
            var query = Queryable.Where(e => string.IsNullOrEmpty(searchParams.Filter) || e.Name == null || e.Name.ToLower().Contains(searchParams.Filter.ToLower()));

            query = searchParams.OrderBy switch
            {
                DishPageableListOrderOptions.NAME_DESC => query.OrderByDescending(e => e.Name),
                _ => query.OrderBy(e => e.Name),
            };

            var results = query.Skip(searchParams.Skip).Take(searchParams.PageSize).ToList();

            return new PageableResult<DishModel>(
                pageSize: searchParams.PageSize,
                currentPage: searchParams.CurrentPage,
                results: results.Select(a => Mapper.Map<DishModel>(a)).ToList());
        }
    }
}
