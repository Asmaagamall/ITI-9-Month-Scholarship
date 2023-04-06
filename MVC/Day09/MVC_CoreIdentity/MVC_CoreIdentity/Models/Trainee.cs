using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CoreIdentity.Models
{
    public enum Gender
    {
        Female , Male
    }
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50 , ErrorMessage = "Too long name")]
        public string Name { get; set; }
        
        public Gender Gender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate {  get; set; } 

        public List<Course> Courses { get; set; }

        [ForeignKey(nameof(Course))]
        public int TrackId { get; set; }
        public virtual Track track { get; set; }
    }
}
