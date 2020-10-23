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
            List<Series> values = repo.Series;
            return View(values);
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

        public ActionResult Capitulos(int id)
        {
            List<Capitulos> values = repo.Capitulos.Where(c => c.SerieId == id).ToList();
            ViewBag.NameSerie = repo.Series.FirstOrDefault(s => s.ID == id).Name;
            ViewBag.ImagenSerie = repo.Series.FirstOrDefault(s => s.ID == id).ImagePath;
            ViewBag.Description = repo.Series.FirstOrDefault(s => s.ID == id).Synopsis;
            //Enviar Categoria
            int Idcategoria = repo.Series.FirstOrDefault(s => s.ID == id).CategoryId;
            ViewBag.NameCategory = repo.Categorias.FirstOrDefault(s => s.ID == Idcategoria).Name;
            int Idestado = repo.Series.FirstOrDefault(s => s.ID == id).EstadoId;
            ViewBag.estado = repo.Estado.FirstOrDefault(s => s.ID == Idestado).Name;
            return View(values);
        }

        public ActionResult Ver(int id)
        {
            List<Capitulos> values = repo.Capitulos.Where(c => c.ID == id).ToList();
            ViewBag.UrlSerie = repo.Capitulos.FirstOrDefault(s => s.ID == id).Url;
            return View(values);
        }
    }
}