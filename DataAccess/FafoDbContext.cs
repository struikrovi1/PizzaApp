using Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FafoDbContext : DbContext
    {

        public FafoDbContext(DbContextOptions opt) : base(opt)
        {


        }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }



        public DbSet<Order> Orders { get; set; }

        public DbSet<MainSlider> Sliders { get; set; }

        public DbSet<Chefs> Chefs { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Combo> Combos { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
