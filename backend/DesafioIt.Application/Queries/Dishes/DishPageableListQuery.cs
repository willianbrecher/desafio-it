using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.DataTransferObjects.Dishes;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;

namespace DesafioIt.Application.Queries.Dishes
{
    public class DishPageableListQuery : DishPageableListParams, IApplicationQuery<PageableResult<DishModel>>
    {
    }
}
