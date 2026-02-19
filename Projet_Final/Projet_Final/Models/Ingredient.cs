using Projet_Final.Models.Enum;

namespace Projet_Final.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string NomIngredient { get; set; }
        public CategorieEnum Categorie { get; set; }

        public Ingredient() { }

        public Ingredient(string nomingredient, CategorieEnum categorie)
        {
            NomIngredient = nomingredient;
            Categorie = categorie;

        }

        public override string ToString()
        {

            return $"{NomIngredient} {Categorie}";

        }
    }
}
