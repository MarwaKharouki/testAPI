using Microsoft.EntityFrameworkCore;
using NextGenConfig.data.Data;
using NextGenConfig.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace NextGenConfig.Repositories.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDbContext dbContext;
        private DbSet<T> table;
        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
            table = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
        }

        public IEnumerable<T> GetAll(T entity)
        {
            return table.ToList();
        }

        public T GetById(string EntityID)
        {
            return table.Find(EntityID);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
