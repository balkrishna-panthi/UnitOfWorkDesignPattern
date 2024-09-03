using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        //The where TEntity : class constraint ensures that
        //the TEntity type parameter must be a reference type (i.e., a class).
        //It cannot be a value type (like int, bool, etc.).

        TEntity GetEntity(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
