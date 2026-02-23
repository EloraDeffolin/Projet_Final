using Projet_Final.Models;

namespace Projet_Final.Interfaces
{
    public interface IIngredientRecetteRepository
    {
        public void AjouterIngredientRecette(List<IngredientRecette> lir);
        public List<IngredientRecette> Recupereringredientrecettebyrecetteid(int id_recette);
        public List<IngredientRecette> Recupereringredientrecettebyingredientid(int id_ingredient);
        public void SupprimerIngredientRecette(List<IngredientRecette> r);
        public IngredientRecette RecupererIngredientRecettebyid(int id);
        Recette ModifierRecette();
        Recette RecupererRecetteId(int id);
        void SupprimerRecette(Recette r);
    }
}
