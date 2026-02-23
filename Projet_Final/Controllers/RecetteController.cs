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
        
        public class RecetteController : Controller
        {
            private readonly IRecetteService _recetteservice;
            private readonly IIngredientService _ingredientService;

            public RecetteController(IRecetteService recetteservice, IIngredientService ingredientservice)
            {
                _recetteservice = recetteservice;
                _ingredientService = ingredientservice;
            }


            public IActionResult AfficherDetailRecette(int id)
            {
                RecetteDetailDTO detail = _recetteservice.RecupererRecetteDetail(id);


                return View(detail);
            }


            [HttpPost]
            public IActionResult SupprimerRecette(Recette recette)
            {
                if (!ModelState.IsValid)
                {
                    return View("SupprimerRecette", recette);
                }
                _recetteservice.SupprimerRecette(recette);
                return View();
            }

            [HttpGet]
            public IActionResult AjouterRecette()
            {
                List<Ingredient> ingredients = _ingredientService.GetAllIngredient();
                RecetteDetailDTO rdd = new RecetteDetailDTO();
                rdd.Recette = new Recette();
                rdd.Ingredients = new List<IngredientsDTO>();
                foreach(Ingredient i in ingredients) {
                    IngredientsDTO iDTO = new IngredientsDTO();
                    iDTO.Ingredient = i;
                    rdd.Ingredients.Add(iDTO);
                }
                return View(rdd);
            }

            [HttpPost]
            public IActionResult AjouterRecette(RecetteDetailDTO recetteDTO)
            {

                if (!ModelState.IsValid)
                {
                    Console.WriteLine("Test");
                    recetteDTO.Ingredients = new List<IngredientsDTO>();
                    return View("AjouterRecette", recetteDTO);
                }
                _recetteservice.AjouterRecette(recetteDTO);
                return RedirectToAction("Index","Home");
            }

            //[HttpGet("ModifierRecette")]
           // public IActionResult ModifierRecette(int id)
           // {
                //var recette = _recetteservice.RecupererRecetteParId(id);
           //     if (recette == null)
             //       return NotFound();
            //    return View(recette);
           // }

            [HttpPost]
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