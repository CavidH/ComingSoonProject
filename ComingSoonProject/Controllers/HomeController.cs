using System;
using System.Linq;
using System.Threading.Tasks;
using ComingSoonProject.DAL;
using ComingSoonProject.VievModel;
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
            var deadline = await _context.Settings.Where(p=>p.Key=="deadline").FirstAsync();
            var headtxt = await _context.Settings.Where(p=>p.Key=="headtxt").FirstAsync();
            var headcontent = await _context.Settings.Where(p=>p.Key=="headcontent").FirstAsync();
            var HomwVM = new HomeVM()
            {
                Deadline = deadline.Value,
                HeadTxt = headtxt.Value,
                HeadContent = headcontent.Value
            };
            return View(HomwVM);
        }
    }
}
