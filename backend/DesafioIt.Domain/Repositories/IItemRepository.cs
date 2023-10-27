using DesafioIt.Domain.DataTransferObjects.Items;
using DesafioIt.Domain.Interfaces;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Repositories
{
    public interface IItemRepository : ICommonRepository<ItemModel>
    {
        PageableResult<ItemModel> PageableList(ItemPageableListParams searchParams);
    }
}
