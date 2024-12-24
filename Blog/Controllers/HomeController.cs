using System.Collections.Generic;
using System.Web.Mvc;
using Blog.Models;
using Blog.Services;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService = new HomeService();

        public ActionResult Index()
        {
            List<MostView> mostViews = _homeService.GetMostViewList();
            return View(mostViews);
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