using DesafioIt.Domain.Attributes;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Models.Items;
using DesafioIt.EntityFramework.Common;

namespace DesafioIt.EntityFramework.Entities
{
    [AutoMap(typeof(ItemModel), AutoMapperDirections.Both)]
    public class ItemEntity : AuditableEntity
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public DateTimeOffset Disabled { get; set; }
    }
}
