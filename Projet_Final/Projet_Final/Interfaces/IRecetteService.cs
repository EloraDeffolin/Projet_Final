using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IRecetteService
    {
       // public List<Recette> listeRecette();
           public Recette AjouterRecette(Recette recette);

        public void SupprimerRecette(Recette r);

    }
}
