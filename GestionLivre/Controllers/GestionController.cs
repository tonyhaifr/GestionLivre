using GestionSach.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionSach.Controllers
{
    public class GestionController : Controller
    {
        private readonly IServiceLivre _serviceLivre;
        public GestionController(IServiceLivre serviceLivre)
        {
            _serviceLivre = serviceLivre;
        }
        // GET: Gestion
        public ActionResult Index()
        {
            List<Livre> model = _serviceLivre.GetLivres().ToList();
            return View(model);
        }
    }
}