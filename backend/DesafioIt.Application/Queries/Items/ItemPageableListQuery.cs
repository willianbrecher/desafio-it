using DesafioIt.Application.Interfaces;
using DesafioIt.Domain.DataTransferObjects.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Items;

namespace DesafioIt.Application.Queries.Items
{
    public class ItemPageableListQuery : ItemPageableListParams, IApplicationQuery<PageableResult<ItemModel>>
    {
    }
}
