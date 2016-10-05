using GestionSach.Data.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GestionSach.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal Gestion_LivreEntities Context;
        internal DbSet<TEntity> DbSet;

        public Repository(Gestion_LivreEntities context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual TEntity Find(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }
        public virtual void AddRange(List<TEntity> entitie)
        {
            DbSet.AddRange(entitie);
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(params object[] keyValues)
        {
            TEntity entity = DbSet.Find(keyValues);
            Remove(entity);
        }

        public virtual void Remove(object id)
        {
            TEntity entity = DbSet.Find(id);
            Remove(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);

            DbSet.Remove(entity);
        }
        public virtual void RemoveRange(List<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                if (Context.Entry(entity).State == EntityState.Detached)
                    DbSet.Attach(entity);
            }
            DbSet.RemoveRange(entities);
        }
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            List<Expression<Func<TEntity, object>>> includeProperties = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
                query = query.Where(filter);

            if (page != null && pageSize != null)
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);

            if (includeProperties != null)
                includeProperties.ForEach(x => { query = query.Include(x); });

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }
    }
}
