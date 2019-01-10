using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TalentsManagerService.Data.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Int64 id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Int64 id);
        int SaveChanges();
    }
}
