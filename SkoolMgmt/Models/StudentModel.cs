using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkoolMgmt.Models
{
    [Table("Students")]
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Enrollment Number")]
        public string EnrollmentNum { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 13)]
        [Display(Name = "Father's CNIC")]
        public string FatherCNIC { get; set; }

        [StringLength(20)]
        [Display(Name = "Father's Occupation")]
        public string FatherOcc { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "UserName")]
        [DataType(DataType.Date)]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Email Id")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(14, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 11)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNo")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }
    }
}