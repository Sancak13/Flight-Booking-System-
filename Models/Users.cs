using System.ComponentModel.DataAnnotations;

namespace FlightBookingSystem.Models
{
    public class Users
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "User Name Required")]
        [Display(Name = "User Nane")]
        [MinLength(5, ErrorMessage = "Min 5 Char Required"), MaxLength(10, ErrorMessage = "Max 10 Char Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [Display(Name = "Password")]
        [MinLength(5, ErrorMessage = "Min 5 Char Required"), MaxLength(10, ErrorMessage = "Max 10 Char Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email")]
        [MinLength(10, ErrorMessage = "Min 5 Char Required"), MaxLength(50, ErrorMessage = "Max 50 Char Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        [Display(Name = "PhoneNumber")]
        [MinLength(5, ErrorMessage = "Min 5 Char Required"), MaxLength(50, ErrorMessage = "Max 50 Char Required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "FirstName")]
        [MinLength(5, ErrorMessage = "Min 5 Char Required"), MaxLength(50, ErrorMessage = "Max 50 Char Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "LastName")]
        [MinLength(5, ErrorMessage = "Min 5 Char Required"), MaxLength(50, ErrorMessage = "Max 50 Char Required")]
        public string LastName { get; set; }
    }
}
