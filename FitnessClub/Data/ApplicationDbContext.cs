using FitnessApi.Models;
using FitnessClub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}