using System.Web.Mvc;

namespace Sod.Web.Controllers
{
    public class PostController : Controller
    {
        // GET: PostDetails
        public ActionResult Details(int year,string title)
        {
            ViewBag.year = year;
            ViewBag.title = title;
            return View();
        }
    }
}