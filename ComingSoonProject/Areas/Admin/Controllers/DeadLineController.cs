using System.Collections.Generic;
using System.Threading.Tasks;
using ComingSoonProject.DAL;
using ComingSoonProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComingSoonProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DeadLineController : Controller
    {
        private AppDbContext _context { get; }

        public DeadLineController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var deadLine = await _context.Settings.FindAsync();
            return View(deadLine);
        }

        public async Task<IActionResult> Update(int? Id)
        {
            {
                if (Id == null) return NotFound();
                var setting = await _context.Settings.FindAsync(Id);
                if (setting == null) return NotFound();
                return View(setting);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id, SettingDeadLine settingDeadLineV)
        {
            if (Id == null) return NotFound();
            var setting = await _context.Settings.FindAsync(Id);
            if (setting == null) return NotFound();
            setting.DeadLine = settingDeadLineV.DeadLine;
             await _context.SaveChangesAsync();

            return View();
        }
    }
}