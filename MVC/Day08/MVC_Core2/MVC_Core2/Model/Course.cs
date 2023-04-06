using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core2.Model
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Topic { get; set; }

        [Required]
        public int CrsGrade { get; set; }

        [ForeignKey(nameof(Student))]
        public int std_id { get; set; }
    }
}
