using Repository.DBContext;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DataContext dataContext { get; set; }
        public Repository(DataContext dataContext)
        {
                this.dataContext = dataContext;
        }


        public TEntity GetEntity(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }
        public void Add(TEntity entity)
        {
            dataContext.Set<TEntity>().Add(entity);
        }
        public void Remove(TEntity entity)
        {
           dataContext.Set<TEntity>().Remove(entity);
        }
    }
}
