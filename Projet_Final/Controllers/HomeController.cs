using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projet_Final.Interfaces;
using Projet_Final.Models;
using Projet_Final.Service;

namespace Projet_Final.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRecetteService _recetteService;
        public HomeController(IRecetteService recetteService)
        {
            _recetteService = recetteService;
        }

        public  IActionResult Index()
        {
            var recettes = _recetteService.RecupererTouteLesRecettes();

            return View(recettes);
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
