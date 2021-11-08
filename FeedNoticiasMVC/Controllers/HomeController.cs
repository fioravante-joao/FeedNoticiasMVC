using FeedNoticiasMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;

namespace FeedNoticiasMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Duração do cache em Segundos
        [OutputCache(Duration = 60)]
        public PartialViewResult PartialViewNoticias()
        {
            string enderecoFeed = ConfigurationManager.AppSettings["EnderecoFeedNoticias"];
            ViewBag.EnderecoFeedNoticias = enderecoFeed;
            return PartialView(NoticiasReader.ObterNoticias(enderecoFeed));
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