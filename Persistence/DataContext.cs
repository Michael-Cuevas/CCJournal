using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealItem> MealItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Meal>()
                .HasMany(meal => meal.MealItems)
                .WithOne(mealItem => mealItem.Meal)
                .HasForeignKey(mealItem => mealItem.MealId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
