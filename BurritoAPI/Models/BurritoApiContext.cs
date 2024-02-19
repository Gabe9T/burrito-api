using Microsoft.EntityFrameworkCore;

namespace BurritoApi.Models
{
    public class BurritoApiContext : DbContext
    {
        public DbSet<Burrito> Burritos { get; set; }

        public BurritoApiContext(DbContextOptions<BurritoApiContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Burrito>()
              .HasData(
                new Burrito { BurritoId = 1, Name = "Pastor Burrito", Location = "Beto's", Price = 11.00M, Protein = "Pork", Review = "Very juicy pork, choice of black or pinto beans with rice, cheese, sour cream, onions, and cilantro. All salsas included are high quality and not watery.", Rating = 8.8, User = "Gabe" },
                new Burrito { BurritoId = 2, Name = "Veggie Soy Curl Burrito", Location = "Los Gorditos", Price = 12.00M, Protein = "Soy Curls", Review = "Best vegetarian option in town. Comes with fajita veggies, beans, rice, sour cream, and cheese. Salsa bar is not to be slept on.", Rating = 8.2, User = "Gabe" },
                new Burrito { BurritoId = 3, Name = "Pollo Burrito Supreme", Location = "Taqueria Santa Cruz", Price = 9.00M, Protein = "Chicken", Review = "review here", Rating = 8.5, User = "Gabe" },
                new Burrito { BurritoId = 4, Name = "Asada Burrito Supremo", Location = "Pepinos", Price = 14.00M, Protein = "Beef", Review = "Review Here", Rating = 8.4, User = "Ravin" },
                new Burrito { BurritoId = 5, Name = "Beef Bulgogi Burrito", Location = "Korean Twist", Price = 11.00M, Protein = "Beef", Review = "Review Here", Rating = 8.9, User = "Ravin" },
                new Burrito { BurritoId = 6, Name = "Double Bacon Breakfast Burrito", Location = "Muchas Gracias", Price = 8.00M, Protein = "Pork", Review = "Review Here", Rating = 7.7, User = "Ravin" },
                new Burrito { BurritoId = 7, Name = "King Burito add Rice", Location = "King Burrito", Price = 6.00M, Protein = "Beef", Review = "Review Here", Rating = 8.2, User = "Ravin" },
                new Burrito { BurritoId = 8, Name = "Carnitas Burrito", Location = "La Bonita", Price = 10.75M, Protein = "Beef", Review = "Review Here", Rating = 8.1, User = "Noah" },
                new Burrito { BurritoId = 9, Name = "Birria Burrito", Location = "Birria Pepe Chile", Price = 10.00M, Protein = "Beef", Review = "Review Here", Rating = 8.7, User = "Noah" },
                new Burrito { BurritoId = 10, Name = "Shrimp Burrito", Location = "Tito's", Price = 11.00M, Protein = "Shrimp", Review = "Review Here", Rating = 8.3, User = "Noah" }
              );
        }
    }
}