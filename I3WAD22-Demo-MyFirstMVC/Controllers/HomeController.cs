using I3WAD22_Demo_MyFirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Controllers
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
            this._logger.LogInformation("Bienvenue sur l'Index!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Hello")]
        [Route("Home/HelloWorld")]
        public string HelloWorld()
        {
            return "<h1>Hello world!</h1>"; //Ceci est du texte, pas de l'HTML
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
