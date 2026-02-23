namespace Projet_Final.Models
{
    public class RecetteDetailDTO
    {
        public Recette Recette
        {
            get; set;
        }

        public List<IngredientsDTO> Ingredients
        
        {
            get; set;
        }

        public override string ToString()
        {
            string result = "";
            result += Recette.ToString() + "\n";
            foreach (var item in Ingredients)
            {
                result += item.ToString() + "\n";
            }
            return result;
            ;
        }
    }
}
