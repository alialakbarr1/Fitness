using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime{ get; set; }
        [Required]
        public string TypeOfActivity { get; set; }

        public TimeSpan Duration { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal DistanceCovered { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal CaloriesBurned { get; set; }

    }
}
