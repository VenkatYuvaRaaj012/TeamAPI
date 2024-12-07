using System.ComponentModel.DataAnnotations;

namespace TeamApi.Models
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? HobbyName { get; set; }
        [Required]
        public string? Difficulty { get; set; }
        public int TimeSpent { get; set; }
        public bool IsOutdoor { get; set; }
        public int Popularity { get; set; }
    }
}
