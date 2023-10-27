using DesafioIt.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesafioIt.Domain.Models.Dishes
{
    public class DishModel : EntityModel
    {
        public DishModel(string name, string description, double price, string servingSize, string photo, DishType type, Guid? id) : base(id)
        {
            Name = name;
            Description = description;
            Price = price;
            ServingSize = servingSize;
            Photo = photo;
            Type = type;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ServingSize { get; set; }
        public string Photo { get; set; }
        public DishType Type { get; set; }

        public void Update(string name, string description, double price, string servingSize, string photo, DishType type)
        {
            Name = name;
            Description = description;
            Price = price;
            ServingSize = servingSize;
            Photo = photo;
            Type = type;
        }
    }
}
