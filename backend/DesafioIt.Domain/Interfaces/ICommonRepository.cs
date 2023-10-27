using DesafioIt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIt.Domain.Interfaces
{
    public interface ICommonRepository<T> where T : EntityModel
    {
        public void Insert(T obj);

        public void Save(T obj);

        public void InsertOrReplace(T obj);

        public void Delete(Guid id);

        public T Get(Guid id);

        public List<T> List();
    }
}
