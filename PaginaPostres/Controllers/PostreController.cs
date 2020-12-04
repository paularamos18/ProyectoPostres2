using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaPostres.Controllers
{
    public class PostreController : Controller
    {
        // GET: PaginaPostre
        public ActionResult Index()
        {
            return View();
        }
    }
}