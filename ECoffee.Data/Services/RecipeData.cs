using ECoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECoffee.Data.Services
{
    public class RecipeData : IRecipeData
    {
        private readonly ECoffeeDbContext db;

        public RecipeData(ECoffeeDbContext db)
        {
            this.db = db;
        }

        public Recipe Get(int id)
        {
            return db.Recipes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return db.Recipes.OrderBy(r => r.Name);
        }
    }
}
