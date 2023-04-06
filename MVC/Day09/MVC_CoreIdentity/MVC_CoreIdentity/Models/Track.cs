using System.ComponentModel.DataAnnotations;

namespace MVC_CoreIdentity.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Trainee> trainees { get; set; } 
    }
}
