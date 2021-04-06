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
            var cafe = new Product { Id = 1, Name = "Café", Price = 1 };
            var eau = new Product { Id = 2, Name = "Eau", Price = 0.2f };
            var creme = new Product { Id = 3, Name = "Crème", Price = 0.5f };
            var chocolat = new Product { Id = 4, Name = "Chocolat", Price = 1f };
            var the = new Product { Id = 5, Name = "Thé", Price = 2f };
            var lait = new Product { Id = 6, Name = "Lait", Price = 0.4f };
            var sucre = new Product { Id = 7, Name = "Sucre", Price = 0.1f };
            var expressoIngredients = new List<Ingredient>()
            {
                new Ingredient {Product = cafe, Quantity = 1, Description ="1 dose de café"},
                new Ingredient {Product = eau, Quantity = 1, Description ="1 dose d'eau"}
            };
            var allongeIngredients = new List<Ingredient>()
            {
                new Ingredient {Product = cafe, Quantity = 1, Description ="1 dose de café"},
                new Ingredient {Product = eau, Quantity = 2, Description ="2 doses d'eau"}
            };
            var cappuccinoIngredients = new List<Ingredient>()
            {
                new Ingredient {Product = cafe, Quantity = 1, Description ="1 dose de café"},
                new Ingredient {Product = lait, Quantity = 1, Description ="1 dose de lait"},
                new Ingredient {Product = eau, Quantity = 1, Description ="1 dose d'eau"},
                new Ingredient {Product = creme, Quantity = 1, Description ="1 dose de crème"},
            };
            var chocolatIngredients = new List<Ingredient>()
            {
                new Ingredient {Product = chocolat, Quantity = 3, Description ="3 dose de chocolat"},
                new Ingredient {Product = lait, Quantity = 2, Description ="2 doses de lait"},
                new Ingredient {Product = eau, Quantity = 1, Description ="1 doses d'eau"},
                new Ingredient {Product = sucre, Quantity = 1, Description ="1 doses de sucre"}
            };
            var theIngredients = new List<Ingredient>()
            {
                new Ingredient {Product = the, Quantity = 1, Description ="1 dose de thé"},
                new Ingredient {Product = eau, Quantity = 2, Description ="2 doses d'eau"}
            };
            recipes = new List<Recipe>()
            {
                new Recipe {Id = 1, Name = "Expresso", Ingredients = expressoIngredients },
                new Recipe {Id = 2, Name = "Allongé", Ingredients = allongeIngredients },
                new Recipe {Id = 3, Name = "Capuccino", Ingredients = cappuccinoIngredients },
                new Recipe {Id = 4, Name = "Chocolat", Ingredients = chocolatIngredients },
                new Recipe {Id = 5, Name = "Thé", Ingredients = theIngredients }
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
