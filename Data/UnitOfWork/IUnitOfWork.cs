using System;
using GestionSach.Data.Repository;

namespace GestionSach.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        bool SaveChanges();
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}
