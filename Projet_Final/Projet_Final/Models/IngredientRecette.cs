using System.ComponentModel.DataAnnotations.Schema;
using Projet_Final.Models.Enum;

namespace Projet_Final.Models
{
    public class IngredientRecette
    {
        public int Id { get; set; }
        
        public int Id_Recette { get; set; }
        [ForeignKey("Id_Recette")]
        public Recette? Recette { get; set; }

        public int Id_Ingredient { get; set; }
        [ForeignKey("Id_Ingredient")]
        public Ingredient? Ingredient { get; set; }  


        public double Quantite { get; set; }
        public TypeQuantite Typequantite { get; set; }




        public IngredientRecette() { }

        public IngredientRecette(int id_recette, int id_ingredient, double quantite, TypeQuantite typequantite)
        {

        }

            public override string ToString()
        {
            return $"{Id_Recette} {Id_Ingredient} {Quantite} {Typequantite}";
        }

    }
}
