using System;
using System.Linq;
using System.Threading.Tasks;
using ComingSoonProject.DAL;
using ComingSoonProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ComingSoonProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; set; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var DeadLine = await _context.Settings.Where(p => p.key == "deadline").FirstOrDefaultAsync();
            var HomeVM = new HomeSettingVM()
            {
                Deadline = DeadLine.Value
            };
            return View(HomeVM);
        }
    }
}
