using Microsoft.EntityFrameworkCore;
using Projet_Final.DBManager;
using Projet_Final.Interfaces;
using Projet_Final.Models;



namespace Projet_Final.Repository
{
    public class IngredientRecetteRepository : IIngredientRecetteRepository
    {
        private readonly Applicationdbcontext _context;

        public IngredientRecetteRepository(Applicationdbcontext context)
        {

            _context = context;

        }

        public IngredientRecette AjouterIngredientRecette(IngredientRecette ir)
        {
            _context.RecettesIngredients.Add(ir);
            _context.SaveChanges();
            return (ir);
        }

        public List<IngredientRecette> RecupererRecetteDetails(int id_recette)
        {
            List<IngredientRecette> r = _context.RecettesIngredients
                 .Include(r => r.Recette)
                 .Include(r => r.Ingredient)
                 .ToList();

            return r;
           
        }

        public List<IngredientRecette> Recupereringredientrecettebyrecetteid(int id_recette)
        {
            return _context.RecettesIngredients.Where(r => r.Id_Recette == id_recette).ToList();
        }

        public List<IngredientRecette> Recupereringredientrecettebyingredientid(int id_ingredient)
        {
            return _context.RecettesIngredients.Where(r => r.Id_Ingredient == id_ingredient).ToList();
        }

        public void SupprimerIngredientRecette(IngredientRecette r)
        {
            _context.Remove(r);
            _context.SaveChanges();
        }

        public void SupprimerIngredientRecette(List<IngredientRecette> r)
        {
            foreach (IngredientRecette rec in r)
            {
              _context.Remove(rec);
            }
            
            _context.SaveChanges();
        }

        public IngredientRecette RecupererIngredientRecettebyid(int id)
        {
            return _context.RecettesIngredients.SingleOrDefault(r => r.Id == id);
        }

    }
}
