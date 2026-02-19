using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;
using Projet_Final.Service;


namespace Projet_Final.Controllers
{
    [Route("Accueil")]
    public class RecetteController : Controller
    {
        private readonly RecetteService _recetteservice;

        public RecetteController(RecetteService recetteservice)
        {
            _recetteservice = recetteservice;

        }
        [HttpPost("Recette")]
        public IActionResult SupprimerRecette(Recette recette)
        {
            if (!ModelState.IsValid)
            {
                return View("Supprimer Recette", recette);
            }
            _recetteservice.SupprimerRecette(recette);

        }
        [HttpGet("Recette")]
        public IActionResult AjouterRecette(Recette recette)
        {
            if (!ModelState.IsValid)
            {
                return View("Ajouter Recette", recette);
            }
            _recetteservice.AjouterRecette(recette);


        }

           [HttpPost("Recette")]
            public IActionResult ModifierRecette (Recette recette)
            {
              


            }

        }
    }
