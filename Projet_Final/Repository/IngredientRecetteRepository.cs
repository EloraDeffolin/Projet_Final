using Microsoft.EntityFrameworkCore;
using Projet_Final.DBManager;
using Projet_Final.Interfaces;
using Projet_Final.Models;
using System.Security.Cryptography.X509Certificates;



namespace Projet_Final.Repository
{
    public class IngredientRecetteRepository : IIngredientRecetteRepository
    {
        private readonly Applicationdbcontext _context;

        public IngredientRecetteRepository(Applicationdbcontext context)
        {

            _context = context;

        }

        public void AjouterIngredientRecette(List<IngredientRecette> lir)
        {
            foreach (IngredientRecette ir in lir)
            {
                _context.RecettesIngredients.Add(ir);
            }
            _context.SaveChanges();
        }

        public List<IngredientRecette> RecupererRecetteDetails(int id_recette)
        {
            List<IngredientRecette> r = _context.RecettesIngredients
                .Where(r=>r.RecetteId == id_recette)
                 .Include(r => r.Recette)
                 .Include(r => r.Ingredient)
                 .ToList();

            return r;

        }

        public List<IngredientRecette> Recupereringredientrecettebyrecetteid(int id_recette)
        {
            return _context.RecettesIngredients.Where(r => r.RecetteId == id_recette).ToList();
        }

        public List<IngredientRecette> Recupereringredientrecettebyingredientid(int id_ingredient)
        {
            return _context.RecettesIngredients.Where(r => r.IngredientId == id_ingredient).ToList();
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
        public IngredientRecette ModifierIngredientRecette(IngredientRecette ir)
        {
            _context.Update(ir);
            return ir;
        }
        public List<IngredientRecette> RecupererAllIngredientRecette()
        {
            return _context.RecettesIngredients.ToList();
        }
        public List<IngredientRecette> RecupererAllIngredientRecettebyrecetteid(int id_recette)
        {
            return _context.RecettesIngredients.Where(r => r.RecetteId == id_recette).ToList();
        }

        public List<IngredientRecette> RecupererRecette(int id_recette)
        {
            return _context.RecettesIngredients.Where(r => r.RecetteId == id_recette).ToList();
        }


        Recette IIngredientRecetteRepository.ModifierRecette()
        {
            foreach (IngredientRecette rec in _context.RecettesIngredients)
            {
                _context.Update(rec);
            }
            return null;
        }

        Recette IIngredientRecetteRepository.RecupererRecetteId(int id)
        {
            return _context.RecettesIngredients.Where(r => r.RecetteId == id).Select(r => r.Recette).FirstOrDefault();
        }



        void IIngredientRecetteRepository.SupprimerRecette(Recette r)
        {
            foreach (IngredientRecette rec in _context.RecettesIngredients.Where(r => r.RecetteId ==r.Id))
            {
                _context.Remove(rec);
            }
            _context.SaveChanges();
        }
    }
}