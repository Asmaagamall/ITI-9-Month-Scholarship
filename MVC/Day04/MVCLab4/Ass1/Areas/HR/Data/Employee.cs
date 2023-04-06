using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ass1.Areas.HR.Data
{
    enum Gender
    {
        Female , Male
    }
    [Table(name:"Employee Data")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [MaxLength(50 , ErrorMessage = "Too Long Name")]
        [Required(ErrorMessage = "Field Empty")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Field Empty")]
        [MaxLength(50 , ErrorMessage = "Too Long Name")]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [EnumDataType(typeof(Gender))]
        public string Gender { get; set; }

        [Range(3000 , 5000 , ErrorMessage ="Not Valid Salary")]
        [Required(ErrorMessage = "Salary field empty")]
        public decimal Salary { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyy-MM-dd")]
        public DateTime JoinDate { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(11 ,ErrorMessage ="Not valid phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}