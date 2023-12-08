using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessClub.Models
{
    public class Nutrition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NutritionId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }

        public string MealType { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FoodItems { get; set; }

        public double Quantity { get; set; }

        public double CaloriesConsumed { get; set; }

    }
}
