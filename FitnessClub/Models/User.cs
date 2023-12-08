using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using FitnessApi.Models;

namespace FitnessClub.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? FitnessGoal { get; set; }
        public string? Achievments { get; set; }

        public IEnumerable<HealthRecord> HealthRecords { get; set; }
        public IEnumerable<ActivityLog> ActivityLogs { get; set; }
        public IEnumerable<Workout> Workouts { get; set; }
        public IEnumerable<Nutrition> Nutritions { get; set; }
    }
}
