using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Final.Interfaces;
using Projet_Final.Models;

namespace Projet_Final.Service
{
    public class RecetteService : IRecetteRepository
    {
        private readonly IIngredientRecetteRepository _ingredientRecetteRepository;

        public RecetteService(IIngredientRecetteRepository ingredientRecetteRepository)
        {
            _ingredientRecetteRepository = ingredientRecetteRepository;
        }
        public Recette AjouterRecette(Recette recette)
        {
            //  ajouter une recette
            //  enregistrer la recette dans une base de données
            // et retourner la recette ajoutée avec son ID généré
            return recette; // Retourne la recette ajoutée
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
    }
}

    
