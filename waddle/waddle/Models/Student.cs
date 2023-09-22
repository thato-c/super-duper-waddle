using System.ComponentModel.DataAnnotations;

namespace waddle.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string StudentEmail { get; set;}

        [Required(ErrorMessage = "Phone number is required")]
        public string StudentPhone { get; set;}
    }
}
