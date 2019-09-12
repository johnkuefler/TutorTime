using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorTime.Models;

namespace TutorTime.Controllers
{
    public class HomeController : Controller
    {
        private TutorDbContext context;

        public HomeController(TutorDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TutorRequests(int id)
        {
            var tutor = context.Tutors.Find(id);
            return View(tutor);
        }

//-----------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
