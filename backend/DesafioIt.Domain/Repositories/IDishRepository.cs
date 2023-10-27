using DesafioIt.Domain.DataTransferObjects.Dishes;
using DesafioIt.Domain.Interfaces;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Repositories
{
    public interface IDishRepository : ICommonRepository<DishModel>
    {
        PageableResult<DishModel> PageableList(DishPageableListParams searchParams);
    }
}
