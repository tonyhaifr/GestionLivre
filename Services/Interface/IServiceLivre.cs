using System;
using System.Collections.Generic;

using Models;

namespace GestionSach.Contracts
{
    public interface IServiceLivre : IDisposable
    {

        IEnumerable<Livre> GetLivres();
    }
}
