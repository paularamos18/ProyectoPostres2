using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaPostres.Controllers
{
    public class RecetasController : Controller
    {
        // GET: Recetas
        public ActionResult Index()
        {
            return View();
        }
    }
}