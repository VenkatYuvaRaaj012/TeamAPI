using System.ComponentModel.DataAnnotations;

namespace TeamApi.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string? CollegeProgram { get; set; }
        [Required]
        public string? YearInProgram { get; set; }
    }
}
