using ComingSoonProject.Models;
using ComingSoonProject.VievModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ComingSoonProject.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager { get; }
        private SignInManager<ApplicationUser> _signManager { get; }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }

        public IActionResult Index()
        {
            //_userManager
            return View();
        }
        //[ActionName("Register")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FullName = registerVM.FullName,
                    UserName = registerVM.UserName,
                    Email = registerVM.Email,
                };
                var result = await _userManager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(registerVM);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginVm loginVm)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginVm.Email);
                if (user == null) return NotFound();

                var login = await _signManager.PasswordSignInAsync(user, loginVm.Password, loginVm.RememberMe, true);
                if (login.Succeeded)
                {
                    await _signManager.SignInAsync(user, loginVm.RememberMe);

                }
                return RedirectToAction("Index", "Home");
            }

            return View(loginVm);
        }
    }
}
