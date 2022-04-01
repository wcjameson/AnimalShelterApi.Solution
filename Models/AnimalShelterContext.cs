using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Robert", Species = "Dog" },
              new Animal { AnimalId = 2, Name = "Meowsen", Species = "Cat" },
              new Animal { AnimalId = 3, Name = "Arthur", Species = "Dog" },
              new Animal { AnimalId = 4, Name = "Winston", Species = "Cat" },
              new Animal { AnimalId = 5, Name = "Charles", Species = "Dog" }
          );
    }
  }
}