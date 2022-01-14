using Microsoft.AspNetCore.Mvc;

namespace ComingSoonProject.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
            
            //  site title yaz!
        }
    }
}