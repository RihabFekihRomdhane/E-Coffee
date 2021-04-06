using ECoffee.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Data.Services
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetAll();
        Recipe Get(int id);
    }
}
