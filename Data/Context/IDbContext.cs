using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GestionSach.Data.Context
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        void SetEntityState<TEntity>(TEntity entity, EntityState entityState) where TEntity : class;
        bool IsEntityState<TEntity>(TEntity entity, EntityState entityState) where TEntity : class;
    }
}