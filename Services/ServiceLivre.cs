using System.Collections.Generic;
using GestionSach.Contracts;
using GestionSach.Data.UnitOfWork;
using Models;

namespace GestionSach.Services
{
    public class ServiceLivre : BaseService, IServiceLivre
    {
        #region Constructor

        public ServiceLivre(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
         }

        #endregion

        #region Methods
        /// <summary>
        /// Retourne l'intégralité des nabms, ordonnées par code.
        /// </summary>
        /// <returns>Nabms</returns>
        public IEnumerable<Livre> GetLivres()
        {
            //var include = new List<Expression<Func<Nabm, object>>> { x => x.Reference };
            return UnitOfWork.Repository<Livre>().Get();
        }
        #endregion
    }
}
