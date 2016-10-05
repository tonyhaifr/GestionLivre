using Core.Enums;
using Core.Extensions;
using GestionSach.Contracts;
using GestionSach.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionSach.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceLivre _serviceLivre;
        public HomeController(IServiceLivre serviceLivre)
        {
            _serviceLivre = serviceLivre;
        }

        public ActionResult Index()
        {
            LivreViewModel model = new LivreViewModel();
            model.ListeNiveauUrgence = (Enum.GetValues(typeof(UrgenceTypeEnum))).Cast<UrgenceTypeEnum>().ToSelectList(x => x.GetStringValue(), x => (int)x).ToList();

           
            return View(model);
        }

            
    public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}