using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Abstract;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProposalsRepository _repository;

        public HomeController(IProposalsRepository repo )
        {
            _repository = repo;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var proposals= _repository.Proposals.ToList();
            return View(proposals);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
