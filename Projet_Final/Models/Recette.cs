namespace Projet_Final.Models
{
    public class Recette
    {
        public int ID { get; set; }
        public string TitreRecette { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public string UrlImage { get; set; }
        public string AuteurRecette { get; set; }


        public Recette() { }

        public Recette(string titrerecette, string description, string instruction, string urlimage, string auteurrecette)
        {
            TitreRecette = titrerecette;
            Description = description;
            Instruction = instruction;
            UrlImage = urlimage;
            AuteurRecette = auteurrecette;

        }

        public override string ToString()
        {
            return $"{TitreRecette} {Description} {Instruction} {UrlImage} {AuteurRecette}";
        }











    }

   
}
