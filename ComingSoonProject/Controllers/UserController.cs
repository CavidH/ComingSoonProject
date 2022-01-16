using ComingSoonProject.Models;
using ComingSoonProject.VievModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComingSoonProject.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager { get; }
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //_userManager
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserRegisterVM registerVM)
        {
            return View();
        }
    }
}
