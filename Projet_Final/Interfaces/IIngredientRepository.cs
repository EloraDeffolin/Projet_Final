using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IIngredientRepository
    {
        public void SupprimerIngredient(int id);

        public Ingredient AjouterIngredient(Ingredient ingredient);

    }
}
