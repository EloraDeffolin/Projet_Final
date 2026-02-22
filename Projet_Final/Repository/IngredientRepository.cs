using Projet_Final.DBManager;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly Applicationdbcontext _context;

        public IngredientRepository(Applicationdbcontext context)
        {

            _context = context;

        }

        public void SupprimerIngredient(int id)
        {

            _context.Remove(id);
            _context.SaveChanges();
        }

        public Ingredient AjouterIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

    }
}
