using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RockyGroomingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This application was created for Object Oriented Class II. " +
                " This is not a real business. Rocky is one of my dogs name.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "My Contact is huertala83@gmail.com";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
