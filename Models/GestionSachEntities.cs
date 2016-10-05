using System.Data.Entity;
using BioBook.Data.Context;

namespace BioBook.Model
{
    public partial class BiobookEntities : IDbContext
    {
        public BiobookEntities(string connectionString)
            : base(connectionString)
        {

        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void SetEntityState<TEntity>(TEntity entity, EntityState entityState) where TEntity : class
        {
            Entry(entity).State = entityState;
        }

        public bool IsEntityState<TEntity>(TEntity entity, EntityState entityState) where TEntity : class
        {
            return Entry(entity).State == entityState;
        }
    }
}
