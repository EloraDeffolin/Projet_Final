using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Service
{
    public class RecetteService : IRecetteService
    {
        private readonly IIngredientRecetteRepository _ingredientRecetteRepository;
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IIngredientRecetteRepository ingredientRecetteRepository, IRecetteRepository recetteRepository)
        {
            _ingredientRecetteRepository = ingredientRecetteRepository;
            _recetteRepository = recetteRepository;
        }

        public Recette AjouterRecette(RecetteDetailDTO recette)
        {

            _recetteRepository.AjouterRecette(recette.Recette);
            List<IngredientRecette> lir = new List<IngredientRecette>();

            for (int i = 0; i < recette.Ingredients.Count; i++)
            {


                lir.Add(new IngredientRecette(
                    recette.Recette.ID,
                    (int)recette.Ingredients[i].Id,
                    recette.Ingredients[i].Quantite,
                    recette.Ingredients[i].TypeQuantite
                    ));
            }

            _ingredientRecetteRepository.AjouterIngredientRecette(lir);
            //  ajouter une recette
            //  enregistrer la recette dans une base de données
            // et retourner la recette ajoutée avec son ID généré
            return recette.Recette; // Retourne la recette ajoutée
        }
        public void SupprimerRecette(Recette r)
        {
            // supprimer une recette
            //  supprimer la recette de la base de données
        }

        public Recette RecupererRecetteId(int id)
        {
            // récupérer une recette par son ID
            //  rechercher la recette dans la base de données en utilisant l'ID
            // et retourner la recette trouvée
            return new Recette(); // Retourne la recette trouvée
        }
        public Recette ModifierRecette(Recette recette)
        {
            // modifier une recette
            //  mettre à jour les informations de la recette dans la base de données
            // et retourner la recette modifiée
            return recette; // Retourne la recette modifiée

        }
        public RecetteDetailDTO RecupererRecetteDetail(int id)
        {
            List<IngredientRecette> lis = _ingredientRecetteRepository.Recupereringredientrecettebyrecetteid(id);
            RecetteDetailDTO rdo = new RecetteDetailDTO();
            rdo.Recette = lis[0].Recette; 
                rdo.Ingredients = new List<IngredientsDTO>();
            foreach (IngredientRecette ir in lis)
            {
                IngredientsDTO io = new IngredientsDTO();
                io.Ingredient = ir.Ingredient;
                rdo.Ingredients.Add(io);
            }

            return rdo;
        }
        public List<Recette> RecupererTouteLesRecettes()
        {
            return _recetteRepository.RecupererTouteLesRecettes();
        }
    }
}


