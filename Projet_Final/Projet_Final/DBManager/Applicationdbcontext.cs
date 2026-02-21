using Microsoft.EntityFrameworkCore;
using Projet_Final.Models;

namespace Projet_Final.DBManager
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<Recette> Recettes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientRecette> RecettesIngredients { get; set; }

    }
}
