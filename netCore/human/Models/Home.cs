using System.ComponentModel.DataAnnotations;
namespace YourNamespace.Models
{
    public class User
    {
        
        [Required(ErrorMessage="You need to enter in a first name!")]
        [MinLength(3, ErrorMessage="Name too short!")]
	[RegularExpression(@ter"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        public string First_Name { get; set; }

		[Required(ErrorMessage="You need to enter in a last name!")]
        [MinLength(3, ErrorMessage="Name too short!")]
        public string Last_Name { get; set; }
 
        [Required(ErrorMessage="You need to enter in an email!")]
        [EmailAddress(ErrorMessage="You need to enter in a valid email!")]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Please enter in a password!")]
		[MinLength(8, ErrorMessage="Password cannot be shorter than 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
