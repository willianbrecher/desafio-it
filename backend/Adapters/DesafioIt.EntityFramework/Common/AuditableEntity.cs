using DesafioIt.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.EntityFramework.Common
{
    [Index(nameof(CreatedAt))]
    [Index(nameof(UpdatedAt))]
    [Index(nameof(IsDeleted))]
    public class AuditableEntity : CommonEntity, IAuditableEntity
    {
        [Required] public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        [Required] public Guid CreatedBy { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTimeOffset? IsDeleted { get; set; }
    }
}
