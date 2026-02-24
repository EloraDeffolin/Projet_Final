using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Service
{
    public class RecetteService : IRecetteService
    {
        private readonly IIngredientRecetteRepository _ingredientRecetteRepository;
        private readonly IRecetteRepository _recetteRepository;
        private readonly IIngredientRepository _ingredientRepository;

        public RecetteService(IIngredientRecetteRepository ingredientRecetteRepository, IRecetteRepository recetteRepository, IIngredientRepository ingredientRepository)
        {
            _ingredientRecetteRepository = ingredientRecetteRepository;
            _recetteRepository = recetteRepository;
            _ingredientRepository = ingredientRepository;
        }

        public Recette AjouterRecette(RecetteDetailDTO recette)
        {

            _recetteRepository.AjouterRecette(recette.Recette);
            List<IngredientRecette> lir = new List<IngredientRecette>();

            for (int i = 0; i < recette.Ingredients.Count; i++)
            {
                IngredientRecette ir = new IngredientRecette(
                    recette.Recette.ID,
                    recette.Ingredients[i].Id ?? 0,
                    recette.Ingredients[i].Quantite,
                    recette.Ingredients[i].TypeQuantite);

                Console.WriteLine(ir);

                lir.Add(ir

                    );
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

            return _recetteRepository.RecupererRecetteId(id);
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
            rdo.Recette = RecupererRecetteId(lis[0].RecetteId); 
            rdo.Ingredients = new List<IngredientsDTO>();
            foreach (IngredientRecette ir in lis)
            {
                IngredientsDTO io = new IngredientsDTO();
                io.Quantite = (int)ir.Quantite;
                io.TypeQuantite = ir.Typequantite;
                io.Ingredient = _ingredientRepository.GetById(ir.IngredientId);
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


