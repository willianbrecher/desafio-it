using DesafioIt.Domain.Attributes;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Items;
using DesafioIt.EntityFramework.Common;

namespace DesafioIt.EntityFramework.Entities
{
    [AutoMap(typeof(ItemValueModel), AutoMapperDirections.Both)]
    public class ItemValueEntity : AuditableEntity
    {
        public Guid ItemId { get; set; }
        public double Value { get; set; }
        public DateTimeOffset ValidFromDate { get; set; }
    }
}
