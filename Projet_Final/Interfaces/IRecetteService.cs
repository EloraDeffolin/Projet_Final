using Projet_Final.Models;
using Projet_Final.Service;

namespace Projet_Final.Interfaces
{
    public interface IRecetteService
    {
       // public List<Recette> listeRecette();
           public Recette AjouterRecette(RecetteDetailDTO recette);
        Recette ModifierRecette(Recette recette);
        public void SupprimerRecette(Recette r);
        RecetteDetailDTO RecupererRecetteDetail(int id);
        public List<Recette> RecupererTouteLesRecettes();

    }
}
