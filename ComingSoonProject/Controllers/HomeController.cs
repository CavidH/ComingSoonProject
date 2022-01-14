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
            //var c = DateAndTime.Now;
            //var resulttime= c.ToString("dd MMM , yyyy");
            //var dsss=c.TimeOfDay;
            //var dc = DateTime.Now;
            //var dsc = DateTime.UtcNow;

            //ViewBag.time = resulttime;

            return View(HomeVM);
        }
    }
}
