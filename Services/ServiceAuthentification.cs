using System;
using System.DirectoryServices.AccountManagement;
using BioBook.Contracts;

namespace BioBook.Services
{
    public class ServiceAuthentification : IServiceAuthentification
    {
        /// <summary>
        /// Retourne le nom complet d'un intervenant à l'aide de son nom de compte.
        /// </summary>
        /// <param name="name">Nom de compte sur l'Active Directory</param>
        /// <returns>Nom complet de l'intervenant</returns>
        public string GetUserFullName(string name)
        {
            using (var context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal principal = UserPrincipal.FindByIdentity(context, name);
                return principal != null ? String.Format(String.IsNullOrWhiteSpace(principal.GivenName) ? "{0}" : "{0}, {1}", principal.Surname, principal.GivenName) : String.Empty;
            }
        }
    }
}
