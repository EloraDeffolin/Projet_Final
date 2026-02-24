using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
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
            Ingredient ingredient = _context.Ingredients.SingleOrDefault(i => i.Id == id);
            _context.Remove(ingredient);
            _context.SaveChanges();
        }

        public Ingredient AjouterIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

       public List<Ingredient> GetAll()
        {
            return _context.Ingredients.ToList();      }

        public Ingredient GetById(int id)
        {
            return _context.Ingredients.SingleOrDefault(i => i.Id == id);
        }
    }
}