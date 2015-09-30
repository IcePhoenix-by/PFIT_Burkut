using PFIT_Burkut.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFIT_Burkut.WebUI.Controllers
{
    public class HomeController : Controller
    {
      public  IFilmRepository FilmRepository { get; set; }
       public HomeController(IFilmRepository FilmRepository)
        {
            this.FilmRepository = FilmRepository;
        }
        public ActionResult Index()
        {
            return View(FilmRepository.getAll());
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