using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;
using Projet_Final.Service;


namespace Projet_Final.Controllers
{
    namespace Projet_Final.Controllers
    {
        [Route("Accueil")]
        public class RecetteController : Controller
        {
            private readonly IRecetteService _recetteservice;

            public RecetteController(IRecetteService recetteservice)
            {
                _recetteservice = recetteservice;
            }

            [HttpPost("SupprimerRecette")]
            public IActionResult SupprimerRecette(Recette recette)
            {
                if (!ModelState.IsValid)
                {
                    return View("SupprimerRecette", recette);
                }
                _recetteservice.SupprimerRecette(recette);
                return View(); ;
            }

            [HttpGet("AjouterRecette")]
            public IActionResult AjouterRecette()
            {
                return View();
            }

            [HttpPost("AjouterRecette")]
            public IActionResult AjouterRecette(Recette recette)
            {
                if (!ModelState.IsValid)
                {
                    return View("AjouterRecette", recette);
                }
                _recetteservice.AjouterRecette(recette);
                return View(); ;
            }

            [HttpGet("ModifierRecette")]
            public IActionResult ModifierRecette(int id)
            {
                var recette = _recetteservice.RecupererRecetteParId(id);
                if (recette == null)
                    return NotFound();
                return View(recette);
            }

            [HttpPost("ModifierRecette")]
            public IActionResult ModifierRecette(Recette recette)
            {
                if (!ModelState.IsValid)
                {
                    return View("ModifierRecette", recette);
                }
                _recetteservice.ModifierRecette(recette);
                return View();
            }
        }
    }
}