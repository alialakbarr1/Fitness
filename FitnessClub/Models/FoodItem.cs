using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessClub.Models
{
    public class FoodItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodItemId { get; set; }

        public string FoodItemName { get; set; }

        public double CaloriesPer100g { get; set; }

        public double CarbohydratesPer100g { get; set; }

        public double ProteinsPer100g { get; set; }

        public double FatsPer100g { get; set; }

        public string VitaminsAndMineralsContent { get; set; }

        public string FoodCategory { get; set; }
        public IEnumerable<Nutrition> Nutritions { get; set; }
    }
}
