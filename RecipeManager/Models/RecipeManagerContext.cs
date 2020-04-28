using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace RecipeManager.Models
{
    public class RecipeManagerContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=recipes.db");
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Step> Steps { get; set; }
    }

    public class Ingredient
    {
        public int IngredientId {get; set;}
        public string Name { get; set; }

        public virtual Recipe Recipe { get; set; }
    }

    public class Step
    {
        public int StepId { get; set; }
        public string Name { get; set; }

        public virtual Recipe Recipe { get; set; }
    }

}
