using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IRecetteService
    {
       // public List<Recette> listeRecette();
           public Recette AjouterRecette(Recette recette);
        void ModifierRecette(Recette recette);
        string? RecupererRecetteParId(int id);
        public void SupprimerRecette(Recette r);

    }
}
