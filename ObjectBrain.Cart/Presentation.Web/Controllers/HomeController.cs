using Microsoft.AspNetCore.Mvc;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name)
        {
            return $"Helle {name}";
        }
    }
}
