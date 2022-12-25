using Projeveritabanıdeneme.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeveritabanıdeneme.Controllers
{
    public class DanışmanController : Controller
    {
        deneme3Entities db = new deneme3Entities();
        // GET: Danışman
        public ActionResult Index()
        {
            var model = db.Danışman.ToList();
            return View(model);
        }
    }
}