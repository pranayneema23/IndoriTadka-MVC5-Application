using IndoriTadka.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndoriTadka.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant { Id =1, Name = "Laal balti", Cuisine = CuisineType.Indian},
                    new Restaurant { Id =2, Name = "Pizza World", Cuisine = CuisineType.Italina},
                    new Restaurant { Id =3, Name = "Bombay Chinese ", Cuisine = CuisineType.Chinese}
                };
        }

        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
