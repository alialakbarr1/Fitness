using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessApi.Models
{
    public class HealthRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; } // Body Mass Index
        public int BloodPressureSystolic { get; set; } 
        public int BloodPressureDiastolic { get; set; } 
        public double BodyFatPercentage { get; set; }
        public double MuscleMass { get; set; }
        public int RestingHeartRate { get; set; }
        public int TargetHeartRate { get; set; }
        public double WaistCircumference { get; set; }
        public double HipCircumference { get; set; }
        public double WaistToHipRatio { get; set; }
        public double BasalMetabolicRate { get; set; }
        public int BloodGlucoseLevel { get; set; }
        public int TriglyceridesLevel { get; set; }
        
    }

}
