using DesafioIt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.DataTransferObjects.Dishes
{
    public class DishPageableListParams : PaginableQuery<DishPageableListOrderOptions>
    {
    }
}
