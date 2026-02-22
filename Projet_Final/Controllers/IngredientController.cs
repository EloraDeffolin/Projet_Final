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
        [HttpGet("AjouterIngredient")]
        public IActionResult AjouterIngredient()
        {
            return View();
        }
        [HttpPost("AjouterIngredient")]
        public IActionResult AjouterIngredient(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return View("AjouterIngredient", ingredient);
            }
            _ingredientservice.AjouterIngredient(ingredient);
            return View(); ;
        }
         [HttpPost("SupprimerIngredient")]
        public IActionResult SupprimerIngredient(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return View("SupprimerIngredient", ingredient);
            }
            _ingredientservice.SupprimerIngredient(ingredient.Id);
            return View(); ;
        }
    }
}
