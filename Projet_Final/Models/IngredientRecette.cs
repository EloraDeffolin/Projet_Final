using System.ComponentModel.DataAnnotations.Schema;
using Projet_Final.Models.Enum;

namespace Projet_Final.Models
{
    public class IngredientRecette
    {
        public int Id { get; set; }
        
        public int RecetteId { get; set; }
        [ForeignKey("RecetteId")]
        public Recette? Recette { get; set; }

        public int IngredientId { get; set; }
        [ForeignKey("IngredientId")]
        public Ingredient? Ingredient { get; set; }  

        public double Quantite { get; set; }
        public TypeQuantite Typequantite { get; set; }

        public IngredientRecette() { }

        public IngredientRecette(int id_recette, int id_ingredient, double quantite, TypeQuantite typequantite)
        {
            RecetteId = id_recette;
            IngredientId = id_ingredient;
            Quantite = quantite;
            Typequantite = typequantite;
        }

            public override string ToString()
        {
            return $"{RecetteId} {IngredientId} {Quantite} {Typequantite} - Recette : {Recette} Ingredient : {Ingredient}";
        }

    }
}
