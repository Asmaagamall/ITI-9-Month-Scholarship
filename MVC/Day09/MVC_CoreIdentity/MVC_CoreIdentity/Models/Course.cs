using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CoreIdentity.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Topic { get; set; }
        public int Grade { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }

        public virtual Trainee trainee { get; set; }
    }
}
