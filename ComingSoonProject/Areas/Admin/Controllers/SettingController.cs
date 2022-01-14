using System.Threading.Tasks;
using ComingSoonProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComingSoonProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private AppDbContext _context { get;}
        // GET
        public async Task<IActionResult> Index()
        {
            var settings = await _context.Settings.ToListAsync();
            return View(settings);
        }
    }
}