using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Models
{
    public abstract class EntityModel
    {
        public virtual Guid Id { get; protected set; }

        protected EntityModel(Guid? id)
        {
            Id = id.Value;
        }
    }
}
