using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Models.Items
{
    public class ItemValueModel : EntityModel
    {
        public ItemValueModel(Guid itemId, double value, DateTimeOffset validFromDate, Guid? id) : base(id)
        {
            ItemId = itemId;
            Value = value;
            ValidFromDate = validFromDate;
        }

        public Guid ItemId { get; set; }
        public double Value { get; set; }
        public DateTimeOffset ValidFromDate { get; set; }
    }
}
