using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGenConfig.Repositories.IRepository
{

    public interface IBaseRepository<T> where T : class
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetById(string EntityId);
        IEnumerable<T> GetAll(T Entity);
        void Save();
    }
}
