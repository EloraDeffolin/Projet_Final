using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IIngredientService
    {
        public void SupprimerIngredient(int id);
        public Ingredient AjouterIngredient(Ingredient ingredient);
        public List<Ingredient> GetAllIngredient();
    }
}
