using eCoffee.web.Models;
using ECoffee.Data.Services;
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
            var recipe = db.Get(id);
            var priceComputing = new PriceComputing();
            var model = new OrderViewModel {Product = recipe , Price = priceComputing.ComputeRecipePrice(recipe) };
            return View(model);
        }

        
    }
}