using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using YaLlega.Entities;
namespace YaLlega1.Data
{
    public class YaLlega1Context : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public YaLlega1Context(DbContextOptions<YaLlega1Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User tomas = new User()
            {
                Id = 1,
                FirstName = "tomas",
                LastName = "nanni",
                EmailAdress = "tomas@gmail.com",
                Password = "contraseña",
            };

            modelBuilder.Entity<User>().HasData(tomas);

            base.OnModelCreating(modelBuilder);
        }
    }
}

