using System;
using System.Web.Mvc;
using Sod.Services;

namespace Sod.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }
        public ActionResult Index()
        {
            //var model = _personService.FindAll().Select(x=>x.ToViewModel()).ToList();
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            throw new Exception("Test exception");
            return View();
        }

        [Route("404")]
        public ActionResult PageNotFound()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}