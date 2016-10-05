using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GestionSach.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(object id);
        void Add(TEntity entity);
        void AddRange(List<TEntity> entitie);
        void Update(TEntity entity);
        void Remove(params object[] keyValues);
        void Remove(object id);
        void Remove(TEntity entity);
        void RemoveRange(List<TEntity> entities);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            List<Expression<Func<TEntity, object>>> includeProperties = null,
            int? page = null,
            int? pageSize = null);
    }
}
