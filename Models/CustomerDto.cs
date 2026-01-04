using System.ComponentModel.DataAnnotations;
namespace web_blazor_server.Models
{
    public class CustomerDto
    {
        [Required(ErrorMessage = "Full name is required")]
        [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long")]
        public string FullName { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10,12}$",
        ErrorMessage = "Phone number must contain 10 to 12 digits")]
        public string PhoneNumber { get; set; } = "";

        [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
        public string Address { get; set; } = "";

        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters long")]
        public string Message { get; set; } = "";

        [Required(ErrorMessage = "Please select a service")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid service")]
        public int ServiceId { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
        public bool AcceptTerms { get; set; }
    }
}