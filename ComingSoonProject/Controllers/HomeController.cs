using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ComingSoonProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var c = DateAndTime.Now;
            var resulttime= c.ToString("dd MMM , yyyy");
            var dsss=c.TimeOfDay;
            var dc = DateTime.Now;
            var dsc = DateTime.UtcNow;

            ViewBag.time = resulttime;

            return View();
        }
    }
}
