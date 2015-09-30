using PFIT_Burkut.Domain.Abstract;
using PFIT_Burkut.Domain.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFIT_Burkut.Domain.Repository
{
  public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DbSet<T> DbSet { get; set; }
        private EfDbContext DbContext { get; set; }
        public BaseRepository(EfDbContext DbContext)
        {
            this.DbContext = DbContext;
            DbSet = DbContext.Set<T>();
        }

        public void create(T item)
        {
            DbSet.Add(item);
        }

        public T get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> getAll()
        {
            return DbSet;
        }

        public void remove(T item)
        {
            DbSet.Remove(item);
        }
    }
}
