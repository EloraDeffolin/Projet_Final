using Projet_Final.DBManager;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Repository
{
    public class RecetteRepository: IRecetteRepository
    {

        private readonly Applicationdbcontext _context;

        public RecetteRepository(Applicationdbcontext context)
        {
            _context = context;
        }
        public List<Recette> RecupererTouteLesRecettes()
        {
            return _context.Recettes.ToList();
        }

        public void SupprimerRecette(Recette r)
        {

            _context.Remove(r);
            _context.SaveChanges();
        }

        public Recette RecupererRecetteId(int id)
        {
           return _context.Recettes.SingleOrDefault(r => r.ID == id);
        }
        

        public Recette ModifierRecette(Recette recette)
        {
            _context.Update(recette);
            return recette;
        }

        public Recette AjouterRecette(Recette recette)
        {
            _context.Recettes.Add(recette);
            _context.SaveChanges();
            return recette;
        }
      
        
    }

}
