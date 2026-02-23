using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Service
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientrepository;

        public IngredientService(IIngredientRepository ingredientrepository)
        {
            _ingredientrepository = ingredientrepository;
        }
        public Ingredient AjouterIngredient(Ingredient ingredient)
        {
            return _ingredientrepository.AjouterIngredient(ingredient);
        }

        public void SupprimerIngredient(int id)
        {
          _ingredientrepository.SupprimerIngredient(id);
        }

        public List<Ingredient> Ingredients()
        {
            return _ingredientrepository.GetAll();
        }

        public List<Ingredient> GetAllIngredient()
        {
            return _ingredientrepository.GetAll();
        }
    }
}
