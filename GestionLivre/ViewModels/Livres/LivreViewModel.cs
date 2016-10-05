using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionSach.ViewModels
{
    public class LivreViewModel
    {
        public Livre livre = new Livre();
        public List<SelectListItem> ListeNiveauUrgence = new List<SelectListItem>();

    }
}