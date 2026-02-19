using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IRecetteRepository
    {
        public void SupprimerRecette(Recette r);

        public Recette RecupererRecetteId(int id);

        public Recette ModifierRecette(Recette recette);
    }
}
