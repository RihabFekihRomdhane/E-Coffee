using eCoffee.web.Models;
using ECoffee.Data.Models;
using ECoffee.Data.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCoffee.web.Controllers
{
    public class HotDrinksController : Controller
    {
        private readonly IRecipeData db;
        public HotDrinksController(IRecipeData db)
        {
            this.db = db;
        }
        // GET: HotDrinks
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Order(int id)
        {
            var margin = 0;
            int.TryParse(  ConfigurationManager.AppSettings["PriceMargin"],out margin); 
            var recipe = db.Get(id);
            var model = new OrderViewModel {Product = recipe , Price = ComputeRecipePrice(recipe, margin) };
            return View(model);
        }

        private float ComputeRecipePrice(Recipe recipe, int margin)
        {
            float price = 0;
            foreach(var ingredient in recipe.Ingredients)
            {
                price += (ingredient.Product.Price * ingredient.Quantity);
            }
            price += price * margin / 100;
            return price;
        }
    }
}