using Microsoft.AspNetCore.Mvc;

namespace ComingSoonProject.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}