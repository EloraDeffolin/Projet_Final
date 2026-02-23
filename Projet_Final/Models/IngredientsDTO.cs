using Projet_Final.Models.Enum;

namespace Projet_Final.Models
{
    public class IngredientsDTO
    {
        public int? Id { get; set; }

        public Ingredient? Ingredient
        {
            get; set;
        }

        public int Quantite
        {
            get; set;
        }

        public TypeQuantite TypeQuantite
        {
            get; set;
        }

        public override string ToString()
        {
            return $"{Id} {Ingredient?.NomIngredient} {Quantite} {TypeQuantite}";
            ;
        }
    }
}
