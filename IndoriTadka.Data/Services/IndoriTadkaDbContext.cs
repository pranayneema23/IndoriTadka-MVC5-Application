using IndoriTadka.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoriTadka.Data.Services
{
    //To access data inside DB use EF base class DbContext
    //DbContext is gatway to any database
    public class IndoriTadkaDbContext : DbContext
    {
        //Now IndoriTadkaDbContext is a getway to db for this project
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
