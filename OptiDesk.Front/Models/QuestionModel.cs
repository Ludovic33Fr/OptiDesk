using System.ComponentModel.DataAnnotations;

namespace OptiDesk.Front.Models
{
    public class QuestionModel
    {
        // Auto generated
        public string Id { get; set; }

        // Auto generated
        public DateTime CreationDate { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Your question is required")]
        public String Question { get; set; }    
    }
}
