using AnimeFLV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeFLV.Controllers
{
    public class HomeController : Controller
    {
        Repository repo = null;

        public HomeController()
        {
            repo = new Repository();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categorias()
        {
            List<Categorias> values = repo.Categorias;
            return View(values);
        }

        public ActionResult Series(int id)
        {
            List<Series> values = repo.Series.Where(x => x.CategoryId == id).ToList();
            ViewBag.NameCategory = repo.Categorias.FirstOrDefault(x => x.ID == id).Name;
            return View(values);
        }
    }
}