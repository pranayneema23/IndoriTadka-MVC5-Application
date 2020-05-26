using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoriTadka.Data.Models;
using System.Data.Entity;

namespace IndoriTadka.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly IndoriTadkaDbContext db;

        public SqlRestaurantData(IndoriTadkaDbContext db)
        {
            this.db = db;
        }

        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in db.Restaurants
                   orderby r.Name
                   select r;
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var restaurant = db.Restaurants.Find(id);
            if(restaurant != null)
            {
                db.Restaurants.Remove(restaurant);
                db.SaveChanges();
            }
        }
    }
}
