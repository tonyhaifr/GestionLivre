using GestionSach.Data.UnitOfWork;
using System;

namespace GestionSach.Services
{
    public  class BaseService : IDisposable
    {
        protected IUnitOfWork UnitOfWork;
        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    UnitOfWork.Dispose();
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
