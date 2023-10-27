using DesafioIt.EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.EntityFramework.Common
{
    public abstract class CommonEntity : ICommonEntity
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();
    }
}
