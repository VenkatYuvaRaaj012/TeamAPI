using System.ComponentModel.DataAnnotations;

namespace TeamApi.Models
{
    public class BreakfastFood
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FoodName { get; set; }
        public int Calories { get; set; }
        [Required]
        public bool IsVegetarian { get; set; }
        [Required]
        public int PreparationTime { get; set; }
        [Required]
        public string? CuisineType { get; set; }
    }
}
