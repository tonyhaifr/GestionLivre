
using GestionSach.Contracts;
using GestionSach.Data.Context;
using GestionSach.Data.UnitOfWork;
using GestionSach.Services;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using Models;
using System.Configuration;
using System.Web.Mvc;

namespace GestionSach
{
    public class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            IUnityContainer container = new UnityContainer();

            //container.RegisterType<IDbContext, Gestion_LivreEntities>();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceLivre, ServiceLivre>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}