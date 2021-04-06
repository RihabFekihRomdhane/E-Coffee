using ECoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECoffee.Data.Services
{
    public class RecipeDataInMemory : IRecipeData
    {
        List<Recipe> recipes;

        public RecipeDataInMemory()
        {
            var cafe = new Product { Id = 1, Name = "Cafe", Price = 1 };
            var eau = new Product { Id = 2, Name = "Eau", Price = 0.2f };
            var expressoIngredients = new List<Ingredient>()
            {
                new Ingredient {Id = 1, Product = cafe, Quantity = 1, Description ="1 dose de café"},
                new Ingredient {Id = 2, Product = eau, Quantity = 1, Description ="1 dose d'eau"}
            };
            var allongeIngredients = new List<Ingredient>()
            {
                new Ingredient {Id = 1, Product = cafe, Quantity = 1, Description ="1 dose de café"},
                new Ingredient {Id = 3, Product = eau, Quantity = 2, Description ="2 doses d'eau"}
            };
            recipes = new List<Recipe>()
            {
                new Recipe {Id = 1, Name = "Expresso", Ingredients = expressoIngredients },
                new Recipe {Id = 2, Name = "Allonge", Ingredients = allongeIngredients }
            };
        }

        public Recipe Get(int id)
        {
            return recipes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return recipes.OrderBy(r => r.Name);
        }
    }
}
