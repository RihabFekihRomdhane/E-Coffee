using eCoffee.web.Controllers;
using ECoffee.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ECoffee.Test
{
    [TestClass]
    public class PriceComputingTest
    {
        [TestMethod]
        public void ComputeRecipePrice_GivenRecipe_ThenReturnPrice()
        {
            var recipe = new Recipe 
            { 
                Name = "Expresso", 
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient {Product = new Product { Name = "Café", Price = 1 }, Quantity = 1},
                    new Ingredient {Product = new Product { Name = "Eau", Price = 0.2f }, Quantity = 1}
                }
            };

            var pc = new PriceComputing();

            Assert.AreEqual(1.56d , pc.ComputeRecipePrice(recipe), 0.001d);
        }
    }
}
