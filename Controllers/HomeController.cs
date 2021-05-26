using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using waiv_starter.Models;
using InertiaAdapter;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using System;

namespace waiv_starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //your js component file name.
            var componentName = "App";
            //return whatever you want.
            var data = new { id = 123 };
            //return Inertia Result.
            return Inertia.Render(componentName, data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
