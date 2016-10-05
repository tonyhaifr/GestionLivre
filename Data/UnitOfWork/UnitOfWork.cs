using System;
using System.Collections.Generic;
using GestionSach.Data.Context;
using GestionSach.Data.Repository;
using System.Data.Entity.Validation;
using Models;

namespace GestionSach.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly IDbContext _context;
        private Gestion_LivreEntities _context = new Gestion_LivreEntities();

        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        //public UnitOfWork(IDbContext context)
        //{
        //    _context = context;
        //}

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;          
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
                _repositories = new Dictionary<Type, object>();

            var type = typeof(TEntity);

            if (!_repositories.ContainsKey(type))
            {
                Type repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<TEntity>)_repositories[type];
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
