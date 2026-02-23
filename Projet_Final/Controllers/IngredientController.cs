using Microsoft.AspNetCore.Mvc;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Controllers
{



    public class IngredientController : Controller
    {
        private readonly IIngredientService _ingredientservice;
        public IngredientController(IIngredientService ingredientservice)
        {
            _ingredientservice = ingredientservice;
        }

        public IActionResult Ajouter()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Ingredient> list = _ingredientservice.GetAllIngredient();
            return View(list);
        }

        [HttpGet]
        public IActionResult AjouterIngredient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AjouterIngredient(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {

                return View(ingredient);
            }
            _ingredientservice.AjouterIngredient(ingredient);
            return RedirectToAction("Index");
        }

        public IActionResult SupprimerIngredient(int id)
        {
            if (ModelState.IsValid)
            {
                _ingredientservice.SupprimerIngredient(id);
            }

            return RedirectToAction("Index");
        }

    }
}