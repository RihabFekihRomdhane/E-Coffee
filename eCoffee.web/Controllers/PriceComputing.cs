using ECoffee.Data.Models;
using System.Configuration;

namespace eCoffee.web.Controllers
{
    public class PriceComputing
    {
        public int ProfitMargin { get; set; }
        public PriceComputing()
        {
            int.TryParse(ConfigurationManager.AppSettings["PriceMargin"], out int margin);
            ProfitMargin = margin;
        }
        public float ComputeRecipePrice(Recipe recipe)
        {
            float price = 0;
            foreach (var ingredient in recipe.Ingredients)
            {
                price += (ingredient.Product.Price * ingredient.Quantity);
            }
            price += price * ProfitMargin / 100;
            return price;
        }
    }
}