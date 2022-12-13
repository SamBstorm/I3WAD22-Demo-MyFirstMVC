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

        [ViewData]
        public string Title { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            HomeIndexViewModel model = new HomeIndexViewModel(
                "Nouvelle page d'accueil!",
                new List<Student>
                {
                    new Student {Prenom = "Sara", Nom = "Pehlivan", DateNaissance = new DateTime(1987,9,27), Email="sara.pehlivan@interface3.be"},
                    new Student {Prenom = "Allessandra", Nom = "Rafaele", DateNaissance = new DateTime(1987,9,27), Email="alessandra.rafaele@interface3.be"},
                    new Student {Prenom = "Eleonore", Nom = "Stultjens", DateNaissance = new DateTime(1987,9,27), Email="eleonore.stultjens@interface3.be"},
                    new Student {Prenom = "Coline", Nom = "Ducourtieux", DateNaissance = new DateTime(1987,9,27), Email="coline.ducourtieux@interface3.be"},
                    new Student {Prenom = "Bao", Nom = "Hoang", DateNaissance = new DateTime(1987,9,27), Email="bao.hoang@interface3.be"},
                    new Student {Prenom = "Mariam", Nom = "Boudrah", DateNaissance = new DateTime(1987,9,27), Email="mariam.boudrah@interface3.be"},
                    new Student {Prenom = "Kasia", Nom = "Drzazgowska", DateNaissance = new DateTime(1987,9,27), Email="kasia.drzazgowska@interface3.be"},
                    new Student {Prenom = "Anissa", Nom = "Bojabah", DateNaissance = new DateTime(1987,9,27), Email="anissa.bojabah@interface3.be"}
                },
                "0800/33.800",
                "samuel.legrain@bstorm.be"
                );
            this._logger.LogInformation("Bienvenue sur l'Index!");
            return View(model);
        }

        public IActionResult Privacy()
        {
            Title = "Contrat de confidentialité";
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
            Title = "Une erreur s'est produite...";
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/SaveText/{text}")]
        public IActionResult SaveText(string text)
        {
            Title = "Sauvegarde de texte :";
            TempData["Text"] = text;
            return View();
        }

        public IActionResult ShowText()
        {
            Title = "Affichage de texte :";
            return View();
        }
    }
}
