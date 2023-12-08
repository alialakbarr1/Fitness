using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessClub.Models
{
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutId { get; set; }

        public int UserId { get; set; }
        public string WorkoutName { get; set;}

        [Column(TypeName = "nvarchar(max)")]
        public string Exercises { get; set; }

        public TimeSpan Duration { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal CaloriesBurned { get; set; }
        public DateTime DateTimeOfWorkout { get; set; }

    }
}
