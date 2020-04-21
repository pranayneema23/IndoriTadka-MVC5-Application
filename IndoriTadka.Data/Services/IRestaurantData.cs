using IndoriTadka.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoriTadka.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll(); 
    }
}
