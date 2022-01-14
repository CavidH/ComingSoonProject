using System.Collections.Generic;
using System.Threading.Tasks;
using ComingSoonProject.DAL;
using ComingSoonProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComingSoonProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private AppDbContext _context { get;}

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return View(settings);
        }
        public  IActionResult  Update(int? Id)
        {
             
            return View();
        }
        public async Task<IActionResult> Update(int? Id,SettingVM settingVm)
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return View( );
        }
        
    }
}