using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class Exercises
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        public string Description { get; set; }

        [Required]
        public string MuscleGroupTargeted { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal CaloriesBurnedPerMinute { get; set; }

        public string EquipmentNeeded { get; set; }
        public IEnumerable<Workout> WorkoutExercises { get; set; }

    }
}
