using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesafioIt.Domain.Models.Items
{
    public class ItemModel : EntityModel
    {
        public ItemModel(string name, string note, string code, DateTimeOffset disabled, Guid? id) : base(id)
        {
            Name = name;
            Note = note;
            Code = code;
            Disabled = disabled;
        }

        public string Name { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public DateTimeOffset Disabled { get; set; }

        public void Update(string name, string note, string code, DateTimeOffset disabled)
        {
            Name = name;
            Note = note;
            Code = code;
            Disabled = disabled;
        }
    }
}
